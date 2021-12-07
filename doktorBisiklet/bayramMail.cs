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
                        mailIslem.mailGonder(mail, "Yeni Yılınız Kutlu Olsun!", "Dr Bisiklet olarak yeni yılınızı en içten dileklerimizle kutlar, sevdiklerinizle mutlu, huzurlu bir yıl geçirmenizi dileriz. Geride bıraktığımız yıl ne kadar eksik sürüşünüz olduysa bu yıl km'ye çevirme vakti, yollarda görüşmek üzere.😎🚲🛣️");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 23 && dateTime.Month == 4 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Ulusal Egemenlik ve Çocuk Bayramınız Kutlu Olsun!", "Gazi Mustafa Kemal Atatürk’ün, Büyük Millet Meclisi’nin açılışı ile beraber çocuklara armağan ettiği bu tarihi günün dünyanın bütün çocuklarına sağlık, mutluluk ve barış getirmesini diliyor. Türkiye Büyük Millet Meclisinin kuruluş günü olan 23 Nisan Ulusal Egemenlik ve Çocuk Bayramı’nı coşku ile kutluyoruz.");
                        kontrol = DateTime.Now.ToString() ;

                    }
                    else if (dateTime.Day == 1 && dateTime.Month == 5 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Emek ve Dayanışma Gününüz Kutlu Olsun!", "1 Mayıs barış, demokrasi ve güvenli bir gelecek için mücadele günüdür. Tüm emekçilerin ve işçilerin, 1 Mayıs İşçi Bayramı kutlu olsun.🇹🇷🔧🔨💪");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 19 && dateTime.Month == 5 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Atatürk'ü Anma, Gençlik ve Spor Bayramınız Kutlu Olsun!", "19 Mayıs, Türk Milleti'nin bağımsızlık ve özgürlük umutlarının inanca dönüştüğü, kurtuluş ateşinin yakıldığı ve aydınlık bir geleceğe olan inancın kuvvetlendiği günün adıdır. 19 Mayıs Atatürk'ü Anma Gençlik ve Spor Bayramımız kutlu olsun.🇹🇷");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 30 && dateTime.Month == 8 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Zafer Bayramınız Kutlu Olsun!", "30 Ağustos Zaferi milli birlik ve beraberlik ruhu içerisinde bağımsızlık meşalesinin ebediyen yanacağı bir zaferdir. 30 Ağustos Zafer Bayramı kutlu olsun.🇹🇷");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 29 && dateTime.Month == 10 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Cumhuriyet Bayramınız Kutlu Olsun!", "İstiklâl mücadelemizin önderi, Cumhuriyetimizin kurucusu Gazi Mustafa Kemal Atatürk ile silah arkadaşları başta olmak üzere bütün şehit ve gazilerimizi şükran, saygı ve rahmetle anıyor, Cumhuriyet'e sahip çıkmanın onurunu yaşıyoruz. Aziz Türk Milleti'nin 29 Ekim Cumhuriyet Bayramı Kutlu olsun!🇹🇷");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 10 && dateTime.Month == 11 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "Ata'mızı büyük bir özlem ve saygıyla anıyoruz!", "10 Kasım 1938 tarihinde aramızdan bedenen ayrılsa da yaşadığımız topraklarda ve dünyada ilkeleri, fikirleri, eserleri ile yaşayan ve daima yaşayacak olan Ata'mızı büyük bir özlem ve saygıyla anıyoruz.♾️");
                        kontrol = DateTime.Now.ToString();

                    }
                    else if (dateTime.Day == 24 && dateTime.Month == 11 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "24 Kasım Öğretmenler Günü kutlu olsun!", "Öğretmen bir sanatkârdır, yarının temelini o attığı gibi, değerli kişilik hamuruna da biçim verir. Tüm Öğretmenlerimizin 24 Kasım Öğretmenler Günü kutlu olsun.");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 15 && dateTime.Month == 7 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "15 Temmuz Demokrasi ve Milli Birlik günü kutlu olsun!", "Cumhuriyetin ve Demokrasinin gücüne inanıyoruz. 15 Temmuz Demokrasi ve Milli Birlik günü kutlu olsun.🇹🇷");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 8 && dateTime.Month == 3 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "8 Mart Dünya Emekçi Kadınlar Günü kutlu olsun!", "8 Mart Dünya Emekçi Kadınlar Günü, saygıdeğer Türk ve Dünya kadınlarına sağlık ve mutluluk getirsin. 8 Mart Dünya Emekçi Kadınlar Günü kutlu olsun.💐🇷");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 8 && dateTime.Month == 3 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "14 Mart Tıp Bayramın kutlu olsun!", "Tüm hayatını başka insanları iyileştirmeye adayan Sağlık çalışalarının 14 Mart Tıp Bayramın kutlu olsun.");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 14 && dateTime.Month == 3 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "14 Mart Tıp Bayramın kutlu olsun!", "Herkes Sevgililer gününde sevgilisine en güzel hediyeyi layık görür. 14 Şubat sevgililer gününde antreman, tur ve yol arkadaşınızın sağlığı için ona en güzel hediyeyi verin. Bisikletinizin düzenli bakımı, konforlu bir sürüş deneyimi için önemlidir. 14 Şubat Sevgililer günü kutlu olsun.🚲♾️❤️");
                        kontrol = DateTime.Now.ToString();
                    }
                    else if (dateTime.Day == 3 && dateTime.Month == 6 && dateTime.Year == yil)
                    {
                        mailIslem.mailGonder(mail, "3 Haziran Dünya Bisiklet günü kutlu olsun!", "Grant Petersen diyor ki' 'Bisikletleri, dünyayı kurtarmak üzere olan güçlü bir sanat olarak düşünün.''Dünyayı kurtarmak, karbon salınımını azaltmak, zinde ve güçlü kalmak için sağlığınız için bisiklete binin. 3 Haziran Dünya Bisiklet günü kutlu olsun.🚲");
                        kontrol = DateTime.Now.ToString();
                    }
                }
            }

        }
    }
}
