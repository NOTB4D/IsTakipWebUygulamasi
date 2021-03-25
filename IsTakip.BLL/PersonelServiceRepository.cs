using IsTakip.DAL;
using IsTakip.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IsTakip.BLL
{
    public class PersonelServiceRepository : Connector
    {
        public List<PersonelService> List()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT [ID],[ProjeAdi],[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[Aciklama],[IslemTipi]  FROM tb_Takip Order By BaslamaTarihi,TeslimTarihi", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetValue(1).ToString(),
                    SorumluAdi = dr.GetValue(2).ToString(),
                    YapilanIs = dr.GetValue(3).ToString(),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    Aciklama = dr.GetValue(8).ToString(),
                    IslemTipi = dr.GetBoolean(9)
                };
                list.Add(service);
            }
            CloseConnection();
            return list;
        }

        public List<PersonelService> TamamlananIsler()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT [ID],[ProjeAdi],[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[Aciklama],[IslemTipi]  FROM tb_Takip WHERE IslemTipi=1 Order By TeslimTarihi", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetValue(1).ToString(),
                    SorumluAdi = dr.GetValue(2).ToString(),
                    YapilanIs = dr.GetValue(3).ToString(),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    Aciklama = dr.GetString(8),
                    IslemTipi = dr.GetBoolean(9)
                };
                list.Add(service);
            }
            CloseConnection();

            return list;
        }

        public List<PersonelService> TamamlanmayanIsler()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT [ID],[ProjeAdi],[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[Aciklama],[IslemTipi]  FROM tb_Takip WHERE IslemTipi=0", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetString(1),
                    SorumluAdi = dr.GetString(2),
                    YapilanIs = dr.GetString(3),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    Aciklama = dr.GetString(8),
                    IslemTipi = dr.GetBoolean(9)
                };
                list.Add(service);
            }
            CloseConnection();

            return list;
        }

        public int TamamlananIsSayisi()
        {
            SqlCommand cmd = new SqlCommand(" Select Count(ID) From tb_Takip where IslemTipi='1'", OpenConnection());

            int satirSayisi = (int)cmd.ExecuteScalar();

            CloseConnection();

            return satirSayisi;
        }
        public int DevamEdenIsSayisi()
        {
            SqlCommand cmd = new SqlCommand(" Select Count(ID) From tb_Takip where IslemTipi='0'", OpenConnection());
            int satirSayisi = (int)cmd.ExecuteScalar();


            CloseConnection();
            return satirSayisi;
        }
        public int ToplamCalismaSaati()
        {
            SqlCommand cmd = new SqlCommand("Select Sum(TahminiIsSuresi) from tb_Takip", OpenConnection());
            int satirSayisi = (int)cmd.ExecuteScalar();

            CloseConnection();

            return satirSayisi;
        }
        public int ToplamIsSayisi()
        {
            SqlCommand cmd = new SqlCommand("Select Count(ID) From tb_Takip", OpenConnection());

            int satirSayisi = (int)cmd.ExecuteScalar();
            CloseConnection();

            return satirSayisi;
        }

        //Son yapilan 10 iş buraya eklenecek
        public List<PersonelService> SonIsler()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("Select top 10 YapilanIs from tb_Takip  Order By ID Desc", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PersonelService p = new PersonelService()
                {
                    YapilanIs = dr.GetString(0)
                };
                list.Add(p);
            }
            CloseConnection();
            return list;
        }

        public List<PersonelService> YapilanIsDetay()
        {
            List<PersonelService> list = new List<PersonelService>();
            SqlCommand cmd = new SqlCommand("Select ProjeAdi,SorumluAdi,IslemTipi,Aciklama from tb_Takip Order By ProjeAdi", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ProjeAdi = dr.GetValue(0).ToString(),
                    SorumluAdi = dr.GetValue(1).ToString(),
                    IslemTipi = dr.GetBoolean(2),
                    Aciklama = dr.GetValue(3).ToString()
                };
                list.Add(service);
            }
            CloseConnection();
            return list;
        }

        public List<PersonelService> BurakDetay()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT  [ID],[ProjeAdi] ,[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[IslemTipi],[Aciklama] FROM tb_Takip Where [SorumluAdi]='Burak Seyhan'", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PersonelService service = new PersonelService() { 
                 ID=dr.GetInt32(0),
                  ProjeAdi=dr.GetString(1),
                   SorumluAdi=dr.GetString(2),
                    YapilanIs=dr.GetString(3),
                    TahminiIsSuresi=dr.GetInt32(4),
                     TamamlanmaMiktari=dr.GetInt32(5),
                      BaslamaTarihi=dr.GetDateTime(6),
                       TeslimTarihi=dr.GetDateTime(7),
                        IslemTipi=dr.GetBoolean(8),
                         Aciklama=dr.GetString(9)
                };
                list.Add(service);
            }

            CloseConnection();
            return list;
        }

        public List<PersonelService> CanDetay()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT  [ID],[ProjeAdi] ,[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[IslemTipi],[Aciklama] FROM tb_Takip Where [SorumluAdi]='Can Sahin'", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetString(1),
                    SorumluAdi = dr.GetString(2),
                    YapilanIs = dr.GetString(3),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    IslemTipi = dr.GetBoolean(8),
                    Aciklama = dr.GetString(9)
                };
                list.Add(service);
            }

            CloseConnection();
            return list;
        }

        public List<PersonelService> EserDetay()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT  [ID],[ProjeAdi] ,[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[IslemTipi],[Aciklama] FROM tb_Takip Where [SorumluAdi]='Eser Kucuker'", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetString(1),
                    SorumluAdi = dr.GetString(2),
                    YapilanIs = dr.GetString(3),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    IslemTipi = dr.GetBoolean(8),
                    Aciklama = dr.GetString(9)
                };
                list.Add(service);
            }

            CloseConnection();
            return list;
        }

        public List<PersonelService> GoncaDetay()
        {
            List<PersonelService> list = new List<PersonelService>();

            SqlCommand cmd = new SqlCommand("SELECT  [ID],[ProjeAdi] ,[SorumluAdi],[YapilanIs],[TahminiIsSuresi],[TamamlanmaMiktari],[BaslamaTarihi],[TeslimTarihi],[Aciklama],[IslemTipi] FROM tb_Takip Where [SorumluAdi]='Gonca Ciftci'", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PersonelService service = new PersonelService()
                {
                    ID = dr.GetInt32(0),
                    ProjeAdi = dr.GetString(1),
                    SorumluAdi = dr.GetString(2),
                    YapilanIs = dr.GetString(3),
                    TahminiIsSuresi = dr.GetInt32(4),
                    TamamlanmaMiktari = dr.GetInt32(5),
                    BaslamaTarihi = dr.GetDateTime(6),
                    TeslimTarihi = dr.GetDateTime(7),
                    Aciklama = dr.GetString(8),
                    IslemTipi=dr.GetBoolean(9)
                };
                list.Add(service);
            }

            CloseConnection();
            return list;
        }
    }
}
