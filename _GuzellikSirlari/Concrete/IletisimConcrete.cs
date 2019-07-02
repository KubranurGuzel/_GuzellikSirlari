using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _GuzellikSirlari.Models;
using _GuzellikSirlari.Abstract;
using System.Data.SqlClient;
using System.Data;
using _GuzellikSirlari.Controllers;

namespace _GuzellikSirlari.Concrete
{
    public class IletisimConcrete : IDataBusiness<Iletisim>
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JMR7LFH\\SQLEXPRESS;Initial Catalog=GuzellikSirlari;Integrated Security=true;");
        public void DeleteData(Iletisim data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_IletisimSil", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IletisimId", data.IletisimId);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public void InsertData(Iletisim data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_IletisimEkle", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Adi", data.Adi);
            command.Parameters.AddWithValue("@Email", data.Email);
            command.Parameters.AddWithValue("@Aciklama", data.Aciklama);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public List<Iletisim> ListData()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_IletisimList", conn);
            command.CommandType = CommandType.StoredProcedure;
            List<Iletisim> iletisim = new List<Iletisim>();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                iletisim.Add(new Iletisim
                {
                    IletisimId = Convert.ToInt32(dr[0]),
                    Adi = dr[1].ToString(),
                    Email = dr[2].ToString(),
                    Aciklama = dr[3].ToString()
                });
            }
            conn.Close();
            conn.Dispose();
            command.Dispose();
            return iletisim;
        }

        public Iletisim Sec(int IletisimId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("[Sp_IletisimSec]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@IletisimId", IletisimId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Iletisim p = new Iletisim
            {
                IletisimId = Convert.ToInt32(dt.Rows[0][0]),
                Adi = dt.Rows[0][1].ToString(),
                Email = dt.Rows[0][2].ToString(),
                Aciklama = dt.Rows[0][3].ToString(),
            };
            return p;
        }

        public void UpdateData(Iletisim data)
        {
            throw new NotImplementedException();
        }
    }
}