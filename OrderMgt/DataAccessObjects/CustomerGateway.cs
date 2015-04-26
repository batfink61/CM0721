using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

// Data Gateway class (Using Facade pattern)
// Enables database read/write access for Customer data

namespace OrderMgt
{
    public static class CustomerGateway
    {
        public static DataSet Find(String customerId)
        {
            // Return the dataset associated with a single instance of a customer

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format("SELECT * FROM customers WHERE id={0}", customerId), conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            return ds;
        }

        public static void Update(String customerId, String name, String address, String town, String postCode, String telephone, String mobile)
        {
            // Update an existing dataset associated with a single customer
            // There's not TRY/Catch because we want errors to be propogated up

            String sql = String.Format("UPDATE customers SET name='{0}', address='{1}', town='{2}', postcode='{3}', tel='{4}', mob='{5}' WHERE id={6}",
                AppHelper.SqlSafe(name), AppHelper.SqlSafe(address), AppHelper.SqlSafe(town), AppHelper.SqlSafe(postCode), AppHelper.SqlSafe(telephone), AppHelper.SqlSafe(mobile), customerId);

            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static String Insert(String name, String address, String town, String postCode, String telephone, String mobile)
        {
            // Insert a new customer dataset
            // There's not TRY/Catch because we want errors to be propogated up

            String customerId = "";
            String sql = String.Format("INSERT INTO customers (name,address,town,postcode,tel,mob,registered) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                AppHelper.SqlSafe(name), AppHelper.SqlSafe(address), AppHelper.SqlSafe(town), AppHelper.SqlSafe(postCode), AppHelper.SqlSafe(telephone), AppHelper.SqlSafe(mobile), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    customerId = dr[0].ToString();
                     
                conn.Close();
            }

            return customerId;
        }

        public static DataSet list()
        {
            // Return a simple list of all customers

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT id,name FROM customers", conn);
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
