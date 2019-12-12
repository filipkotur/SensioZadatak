using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Sensio
{
    public partial class Demo : System.Web.UI.Page
    {
        
        string tekst=ConfigurationManager.AppSettings.Get("Key0");
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        protected void IdSpremi_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "insert into Tablica values('"+TextBox1.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        protected void IdPosalji_Click(object sender, EventArgs e)
        {
            tekst = tekst + TextBox1.Text;
            tekst=tekst.Replace(' ', '&');
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(tekst);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            TextBox2.Text=""+ (int)myHttpWebResponse.StatusCode;
            myHttpWebResponse.Close();
            
        }
    }
}