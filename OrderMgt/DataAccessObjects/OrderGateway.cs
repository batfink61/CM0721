using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace OrderMgt
{
    public static class OrderGateway
    {
        public static DataSet Find(String orderNumber)
        {
            // Return the dataset associated with a single instance of am order

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format("SELECT * FROM orders WHERE id={0}", orderNumber), conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            return ds;
        }

        public static String Create(String customerId, String buildingType, Decimal framePrice, Nullable<DateTime> planningRejection, Nullable<DateTime> planningGranted, Nullable<DateTime> contractSigned, Nullable<DateTime> estimate, Nullable<DateTime> assemblyDate, Nullable<DateTime> foundationReady, Nullable<DateTime> planningInvoice, Nullable<DateTime> orderInvoice, Nullable<DateTime> delayInvoice)
        {
            // Create a new order.
            // An orderId is returned if the order is succesfully created

            String orderId = "";

            //String sql = String.Format("INSERT INTO orders (customerid,buildingtype,frameprice,created,status,planningrejection,planninggranted,contractsigned,estimate,assemblydate,foundationready) VALUES ({0},'{1}',{2},'{3}','{4}','{5}','{5}','{6}','{7}','{8}','{9}')",
            //    customerId, buildingType, framePrice, DateTime.Now.ToString("dd/MM/yyyy"), "", planningRejection, planningGranted, contractSigned, estimate, assemblyDate, foundationReady);


            String sql = String.Format("INSERT INTO orders (customerid,buildingtype,frameprice,created,status,planningrejection,planninggranted,contractsigned,estimatefabdate,assemblydate,foundationready,planninginvoice,orderinvoice,delayinvoice) VALUES ({0},'{1}',{2},'{3}','{4}',null,null,null,null,null,null,null,null,null)",
                customerId, buildingType, framePrice, DateTime.Now.ToString("dd/MM/yyyy"), OrderStatus.Unsubmitted);
            
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    orderId = dr[0].ToString();
                conn.Close();
            }

            return orderId;
        }

        public static void Save(Order order)
        {
            // Update an existing dataset associated with a single customer
            // There's not TRY/Catch because we want errors to be propogated up
            string planningRejected = order.PlanningRejected != null ? order.PlanningRejected.Value.ToString("dd/MM/yyyy") : String.Empty;
            string planningGranted = order.PlanningGranted != null ? order.PlanningGranted.Value.ToString("dd/MM/yyyy") : String.Empty;
            string contractSigned = order.ContractSigned != null ? order.ContractSigned.Value.ToString("dd/MM/yyyy") : String.Empty;
            string estimatedFab = order.EstimatedFab != null ? order.EstimatedFab.Value.ToString("dd/MM/yyyy") : String.Empty;
            string assemblyDate = order.AssemblyDate != null ? order.AssemblyDate.Value.ToString("dd/MM/yyyy") : String.Empty;
            string foundationReady = order.FoundationReady != null ? order.FoundationReady.Value.ToString("dd/MM/yyyy") : String.Empty;
            string planningInvoice = order.PlanningInvoice != null ? order.PlanningInvoice.Value.ToString("dd/MM/yyyy") : String.Empty;
            string orderInvoice = order.OrderInvoice != null ? order.OrderInvoice.Value.ToString("dd/MM/yyyy") :  String.Empty;
            string delayInvoice = order.DelayInvoice != null ? order.DelayInvoice.Value.ToString("dd/MM/yyyy") : String.Empty;

            //String sql = String.Format("UPDATE orders SET status,planningrejection,planninggranted,contractsigned,estimatefabdate,assemblydate,foundationready,planninginvoice,orderinvoice,delayinvoice WHERE id) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10})",
            //    order.Status, planningRejected, planningGranted, contractSigned, estimatedFab, assemblyDate, foundationReady, planningInvoice, orderInvoice, delayInvoice, order.OrderId);

            //String sql = String.Format("UPDATE orders SET status='{0}', planningrejection='{1}', planninggranted='{2}', contractsigned='{3}', estimatefabdate='{4}', assemblydate='{5}', foundationready='{6}', planninginvoice='{7}', orderinvoice='{8}', delayinvoice='{9}' WHERE id={10}",
             //order.Status, planningRejected, planningGranted, contractSigned, estimatedFab, assemblyDate, foundationReady, planningInvoice, orderInvoice, delayInvoice, order.OrderId);

            String sql = "UPDATE Orders SET Status=@var1, PlanningRejection=@var2, PlanningGranted=@var3, ContractSigned=@var4, EstimateFabDate=@var5, AssemblyDate=@var6, FoundationDate=@var7, PlanningInvoice=@var8, OrderInvoice=@var9, DelayInvoice=@var10" + " WHERE ID=@var11";

            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new OleDbParameter("@var1", order.Status.ToString()));
                cmd.Parameters.AddWithValue("@var2", string.IsNullOrEmpty(planningRejected) ? (object)DBNull.Value : planningRejected);
                cmd.Parameters.AddWithValue("@var3", string.IsNullOrEmpty(planningGranted) ? (object)DBNull.Value : planningGranted);
                cmd.Parameters.AddWithValue("@var4", string.IsNullOrEmpty(contractSigned) ? (object)DBNull.Value : contractSigned);
                cmd.Parameters.AddWithValue("@var5", string.IsNullOrEmpty(estimatedFab) ? (object)DBNull.Value : estimatedFab);
                cmd.Parameters.AddWithValue("@var6", string.IsNullOrEmpty(assemblyDate) ? (object)DBNull.Value : assemblyDate);
                cmd.Parameters.AddWithValue("@var7", string.IsNullOrEmpty(foundationReady) ? (object)DBNull.Value : foundationReady);
                cmd.Parameters.AddWithValue("@var8", string.IsNullOrEmpty(planningInvoice) ? (object)DBNull.Value : planningInvoice);
                cmd.Parameters.AddWithValue("@var9", string.IsNullOrEmpty(orderInvoice) ? (object)DBNull.Value : orderInvoice);
                cmd.Parameters.AddWithValue("@var10", string.IsNullOrEmpty(delayInvoice) ? (object)DBNull.Value : delayInvoice);
                cmd.Parameters.Add(new OleDbParameter("@var11", order.OrderId));
                
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "SELECT @@IDENTITY";
                OleDbDataReader dr = cmd.ExecuteReader();
                conn.Close();
            }
        }  // Save an existing Order

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
                    OleDbCommand cmd = new OleDbCommand("SELECT id,customerid FROM orders", conn);
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
    }
}
