﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _161114Csharp4V2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConn = new SqlConnection(ConfigurationSettings.AppSettings["strConn"].ToString());

            DataSet myDS = new DataSet();
            SqlDataAdapter CustomerAD = new SqlDataAdapter("Select * from Customers", myConn);
            SqlDataAdapter OrderdetailAd = new SqlDataAdapter("SELECT [Order Details].OrderID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].UnitPrice*[Order Details].Quantity as SUM   FROM[Order Details] INNER JOIN Products ON[Order Details].ProductID = Products.ProductID", myConn);

            CustomerAD.Fill(myDS, "Customers");
            OrderdetailAd.Fill(myDS, "OrderDetails");

            //Console.Write("Please input customer ID: ");
            //string cID = Console.ReadLine();

            //DataView myView = new DataView(myDS.Tables["Customers"]);
            //myView.RowFilter = "CustomerID = '" + cID + "'";
            //Console.WriteLine(myView[0][0].ToString() + "\t" + myView[0][1].ToString());

            Console.Write("Please input Order ID: ");
            string orderid = Console.ReadLine();
            DataView orderDV = new DataView(myDS.Tables["OrderDetails"]);
            orderDV.RowFilter = "OrderID = '" + orderid + "'";

            Console.WriteLine("OrderId  |ProductID  |Price  |qua    |Sum");
            foreach (DataRowView order in orderDV)
            {
                Console.WriteLine(order[0].ToString() + "\t|" + order[1].ToString() + "\t|" + order[2].ToString() + "\t|" + order[3].ToString() + "\t|" + order[4].ToString());
            }
            //for (int i = 0; i < orderDV.Count; i++)
            //{
                
            //        Console.WriteLine(orderDV[i][0].ToString() + "\t" + orderDV[i][1].ToString() + "\t" + orderDV[i][2].ToString());

            //}
            
        }
    }
}
