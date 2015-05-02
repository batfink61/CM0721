using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

// This static class handles all SQL I/O for the Order tables using Facade pattern

namespace OrderMgt
{
    public static class OrderGateway
    {
        public static DataSet Find(String orderNumber)
        {
            // Return the dataset associated with a single instance of am order
            // ACCESS is restricted to returning a single table.
            // In reality we would use a stored procedure against an industrial DB

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                cmd.CommandText = String.Format("SELECT * FROM orders WHERE id={0};", orderNumber);
                DataTable orders = new DataTable("order");
                da.Fill(orders);
                da.FillSchema(orders, SchemaType.Source);
                ds.Tables.Add(orders);

                cmd.CommandText = String.Format("SELECT * FROM orderbuildingoptions WHERE orderid={0};", orderNumber);
                DataTable orderOptions = new DataTable("orderbuildingoptions");
                da.Fill(orderOptions);
                ds.Tables.Add(orderOptions);

                cmd.CommandText = "SELECT * FROM buildingoptions ORDER BY id;";
                DataTable buildingOptions = new DataTable("possibleBuildingOptions");
                da.Fill(buildingOptions);
                ds.Tables.Add(buildingOptions);

                conn.Close();
            }
            return ds;
        }


        public static void Save(DataSet ds)
        {
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
 
                OleDbCommand cmd= new OleDbCommand(String.Format("DELETE FROM orderbuildingoptions WHERE orderid={0};", ds.Tables["order"].Rows[0]["id"].ToString()), conn);
                cmd.ExecuteNonQuery();
                
                OleDbDataAdapter da = new OleDbDataAdapter("", conn);

                da.SelectCommand.CommandText = "SELECT * FROM orders";
                OleDbCommandBuilder commands = new OleDbCommandBuilder(da);
                da.DeleteCommand = commands.GetDeleteCommand();
                da.UpdateCommand = commands.GetUpdateCommand();
                da.InsertCommand = commands.GetInsertCommand();
                //ds.Tables["order"].Rows[0].AcceptChanges();
                //ds.Tables["order"].Rows[0].SetModified();
                da.Update(ds.Tables["order"]);

                // If this is a new order then there will not be an order number (it will have the default zero)
                // A limitation of ACCESS means that we need to make a second SQL call to get the row updated
                // this gives us an order ID - it's autonum'ed

                if (ds.Tables["order"].Rows[0]["id"].ToString() == "0")
                {
                    String id = "-1";
                    cmd.CommandText = "SELECT @@IDENTITY";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        id = dr[0].ToString();
                        foreach (DataRow row in ds.Tables[1].Rows)
                            row["orderId"] = id;
                    }
                    dr.Close();
                }

                da.SelectCommand.CommandText = "SELECT * FROM orderbuildingoptions ORDER BY id";
                commands = new OleDbCommandBuilder(da);
                da.DeleteCommand = commands.GetDeleteCommand();
                da.UpdateCommand = commands.GetUpdateCommand();
                da.InsertCommand = commands.GetInsertCommand();
                da.Update(ds.Tables["orderbuildingoptions"]);
                conn.Close();
            }

        }
        
        public static DataSet list()
        {
            // Return a simple list of all orders id and customer need more data returned but just a placeholder atm
            // This should be expanded by taking a list of parameters based upon the status of the order to return

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT id,customerid, BuildingType, FramePrice, Created, Status FROM orders", conn);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    conn.Close();
                }
            }
            return ds;
        }

        public static String FindCustomerOrder(String customerId)
        {
            // Return the dataset associated with a Customer

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format("SELECT * FROM orders WHERE CustomerId={0}", customerId), conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            return ds.Tables[0].Rows[0]["ID"].ToString();
        }
        
        public static DataSet ListCustomerOrders()
        {
            String sql = "select o.ID, o.CustomerId, c.Name, o.BuildingType, o.Status FROM Orders o INNER JOIN Customers c on o.CustomerId = c.ID";
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString());
            OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
            DataSet custOrders = new DataSet();
            da.Fill(custOrders);

            return custOrders;
        }
        public static String getLastOrderInProduction()
        {
            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM orders WHERE status=4", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0]["ID"].ToString();
            else
                return "";
        }
    }
}
