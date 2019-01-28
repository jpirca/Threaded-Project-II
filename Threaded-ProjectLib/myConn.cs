using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Treetest
{
    class myConn
    {
        string connetionString;
        SqlConnection cnn;
        SqlCommand command;
       public SqlDataReader dataReader;
        SqlDataAdapter adatper;
        string sql, Output = "";
        string criteria;
       public DataTable dt;


        public bool ConnectDb()
        {

            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\visual studio\Treetest\Treetest\Travelexperts.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            return true;
        }

        
        //public bool FetchData(string query) {
        //    bool dataFound = false;
        //    if (ConnectDb()){
        //       // criteria =search_criteria;
        //        sql = query;
                
           
        //        command = new SqlCommand(sql, cnn);
        //     //   command.Parameters.AddWithValue("@Name",criteria);
        //        dataReader = command.ExecuteReader();
        //       // adatper = new SqlDataAdapter();
        //      //  adatper.InsertCommand = command;
        //      //  adatper.Fill(dt);
        //        /*
        //        while (dataReader.Read())
        //        {
        //            MessageBox.Show(Convert.ToString(dataReader.GetValue(0)) + "" + Convert.ToString(dataReader.GetValue(1)));
        //        }
        //        */
        //        // cnn.Close();
        //        dataFound = true;
        //    }
        //    return dataFound;
        //}

        //public bool FillDataGrid(string query)
        //{
        //    bool dataFound = false;
        //    if (ConnectDb())
        //    {
                
        //        sql = query;


        //         adatper = new SqlDataAdapter(sql,cnn);
                 
        //        dt = new DataTable();
        //          adatper.Fill(dt);
        //        /*
        //        while (dataReader.Read())
        //        {
        //            MessageBox.Show(Convert.ToString(dataReader.GetValue(0)) + "" + Convert.ToString(dataReader.GetValue(1)));
        //        }
        //        */
        //        // cnn.Close();
        //        dataFound = true;
        //    }
        //    return dataFound;
        //}

        //public bool FillDataGrid_Addproduct(string query)
        //{
        //    bool dataFound = false;
        //    if (ConnectDb())
        //    {

        //         sql = query;


        //        command = new SqlCommand(sql, cnn);
        //        //   command.Parameters.AddWithValue("@Name",criteria);
        //        dataReader = command.ExecuteReader();

        //        //  sql = "select products.ProdName,suppliers.SupName from products,products_suppliers,suppliers" +
        //        // " WHERE products.ProductId=products_suppliers.ProductId" +
        //        // " and suppliers.SupplierId=products_suppliers.SupplierId and products_suppliers.ProductSupplierId='" + criteria + "'";
        //        // adatper = new SqlDataAdapter(sql, cnn);

        //        // dt = new DataTable();
        //        // adatper.Fill(dt);

        //        //  while (dataReader.Read())
        //        // {
        //        // MessageBox.Show(Convert.ToString(dataReader.GetValue(0)) + "" + Convert.ToString(dataReader.GetValue(1)));
        //        //  adatper.Fill(dt);
        //        // }

        //        // cnn.Close();
        //        dataFound = true;
        //    }
        //    return dataFound;
        //}



        //public void CloseConnetion()
        //{
        //    cnn.Close();
        //}

        //public bool AddRecord(string query)
        //{
        //    if (ConnectDb())
        //    {
        //        adatper = new SqlDataAdapter();
        //        sql = query;
        //        command = new SqlCommand(sql, cnn);
        //        adatper.InsertCommand = new SqlCommand(sql, cnn);
        //        adatper.InsertCommand.ExecuteNonQuery();
        //        adatper.Dispose();
                             
        //        cnn.Close();


        //    }
        //    return true;
        //}

        //public bool UpdateRecord()
        //{
        //    bool updated = false;
        //    string value = "Soap";
        //    if (ConnectDb())
        //    {
        //        adatper = new SqlDataAdapter();
        //        sql = "update products_reg set productName='"+value+"'"+" where Id=3";
        //        command = new SqlCommand(sql, cnn);
        //        adatper.UpdateCommand=new SqlCommand(sql, cnn);
        //        adatper.UpdateCommand.ExecuteNonQuery();
        //        updated = true;
        //        command.Dispose();
        //        cnn.Close();

        //    }

        //    return updated;

        //}

        //public bool DeleteRecord()
        //{
        //    bool deleted = false;
        //    if (ConnectDb())
        //    {
        //        adatper = new SqlDataAdapter();
        //        sql = "delete from products_reg where id=3";
        //        command = new SqlCommand(sql, cnn);
        //        adatper.DeleteCommand = new SqlCommand(sql,cnn);
        //        adatper.DeleteCommand.ExecuteNonQuery();
        //        deleted = true;
        //        command.Dispose();
        //        cnn.Close();
        //    }
        //    return deleted;
        //}

        //public bool FillDataGrid()
        //{
        //    bool filled=false;
        //    if (ConnectDb())
        //    {
        //        SqlDataAdapter qadapter = new SqlDataAdapter("select * from products_reg", cnn);
        //        dt = new DataTable();
        //        qadapter.Fill(dt);
        //        filled = true;
        //        qadapter.Dispose();
        //        cnn.Close();
        //    }

        //    return filled;

        //}


    }
}
