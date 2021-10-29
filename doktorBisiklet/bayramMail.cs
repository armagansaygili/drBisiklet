using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace doktorBisiklet
{


    class bayramMail
    {
        public void bayramMailGonder()
        {

            Mysql.SqlConnection sqlConnection = new Mysql.SqlConnection();
            sendMail mailIslem = new sendMail();


            for (int i = 1; i<10; i++)
            {

                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                int yil = Convert.ToInt32("202" + i.ToString());
                string kontrol = "";

                MySqlCommand mySqlCommand = new MySqlCommand("Select mus_email from musteri", sqlConnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string mail = mySqlDataReader["mus_email"].ToString();
                    if (dateTime.Day.ToString() == 1.ToString() && dateTime.Month.ToString() == 1.ToString() && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Yeni Yılınız Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 23 && dateTime.Month == 4 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Ulusal Egemenlik ve Çocuk Bayramınız Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString() ;

                    }
                    else if (dateTime.Day == 1 && dateTime.Month == 5 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Emek ve Dayanışma Gününüz Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 19 && dateTime.Month == 5 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Atatürk'ü Anma, Gençlik ve Spor Bayramınız Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 30 && dateTime.Month == 8 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Zafer Bayramınız Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 29 && dateTime.Month == 10 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Cumhuriyet Bayramınız Kutlu Olsun!", "");
                        kontrol = DateTime.Now.ToString();

                    }
                }
            }

        }
    }
}
