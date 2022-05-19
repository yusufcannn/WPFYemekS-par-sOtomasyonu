using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace FoodOtomatıon
{

    public class ProductDal
    {
       
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DPP0GNB;Initial Catalog=DBOtomatıon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // Veri Tabanı bağlantısı 
           
        public List<Database> getProducts()
        {
            sqlConnect();
            SqlCommand command = new SqlCommand("Select * from dbo.Products", con); // tüm ürünleri getir query
           
           SqlDataReader reader = command.ExecuteReader(); // sql okuma komutu
            List<Database> products = new List<Database>();

            while (reader.Read()) // reader oku methdou tüm verileri okuayan kadar çalışacak
            {

                Database product = new Database()  // Database classına veriler list olarak gönderilecek
                {
                    ID = (int)reader[0],
                    SiparisNo = (int)reader[1],
                    SiparisTutarı = (int)reader[2],
                    SiparisAdresi = reader[3].ToString(),
                    Siparis = reader[4].ToString()
                };
                products.Add(product);

            }
            reader.Close();
            con.Close();
            return products; // veriler return ediliecek
            

        }
        public void addProduct(Database database) // urun ekleme methodu
        {
            // Database den gelen verileri sql commander vererek tabloya yazdırma
            sqlConnect();
            SqlCommand command = new SqlCommand("insert into dbo.Products values(@ID,@SiparisNo,@SiparisTutarı,@SiparisAdresi,@Siparis)", con);
            command.Parameters.AddWithValue("@ID", database.ID);
            command.Parameters.AddWithValue("@SiparisNo",database.SiparisNo);
            command.Parameters.AddWithValue("@SiparisTutarı", database.SiparisTutarı);
            command.Parameters.AddWithValue("@SiparisAdresi", database.SiparisAdresi);
            command.Parameters.AddWithValue("@Siparis", database.Siparis);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void updateProduct(Database database)
        {
            // Database den gelen verileri sql commander vasıtasyıla tablodaki verileri günceleme
            sqlConnect();
            SqlCommand command = new SqlCommand("update  dbo.Products set ID=@ID,SiparisNo=@SiparisNo,SiparisTutarı=@SiparisTutarı,SiparisAdresi=@SiparisAdresi,Siparis=@Siparis where ID=@ID", con);
            command.Parameters.AddWithValue("@ID", database.ID);
            command.Parameters.AddWithValue("@SiparisNo", database.SiparisNo);
            command.Parameters.AddWithValue("@SiparisTutarı", database.SiparisTutarı);
            command.Parameters.AddWithValue("@SiparisAdresi", database.SiparisAdresi);
            command.Parameters.AddWithValue("@Siparis", database.Siparis);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void deleteProduct(int id)
        {
            // id bazlı tablodki veriyi silme
            sqlConnect();
            SqlCommand command = new SqlCommand("Delete from dbo.Products where ID=@ID", con);
            command.Parameters.AddWithValue("@ID", id);
            
            command.ExecuteNonQuery();
            con.Close();
        }
        private void sqlConnect()
            // Bağlantı durum kontrol private methodu
        {
            if(con.State ==ConnectionState.Closed)
            {
                con.Open();
            }
        }
       
    }
}
