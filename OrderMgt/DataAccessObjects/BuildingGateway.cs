using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace OrderMgt
{
    public static class BuildingGateway
    {
        public static DataSet Find(String BuildingName)
        {
            // Return the dataset associated with a single instance of a customer

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format("SELECT * FROM buildingTypes WHERE typecode='{0}'", AppHelper.SqlSafe(BuildingName)), conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            return ds;
        }

        public static DataSet List()
        {
            // Return a simple list of all customers

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM buildingTypes", conn);
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


        public static DataSet Options(String buildingType)
        {
            // Return a simple list of all customers

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(String.Format("SELECT id,optionname,optionprice,optiontype FROM buildingOptions WHERE buildingtype='{0}'", buildingType), conn);
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

        public static DataSet FindOption(String optionId)
        {
            // Return a simple list of all customers

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(String.Format("SELECT id,optionname,optionprice,optiontype FROM buildingOptions WHERE id={0}", optionId), conn);
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
