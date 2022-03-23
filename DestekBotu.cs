using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace AskMeProject
{
    public partial class DestekBotu : Form
    {
        public DestekBotu()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Bot(textBox1.Text); textBox1.Text = ""; textBox1.Focus(); }
           
        }
        public static string ad, soyad, yas;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Window.ScrollTo(0, webBrowser1.Document.Window.Size.Height);
        }

        private void DestekBotu_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText += "<center> <p style='color: blue; font-family:calibri'> " + " <img src='https://ictcertify.com/images/referans/meditek.png'/> " + "<br> Meditek Arge Destek Merkezine Hoş Geldiniz <br>  Ben Feyza Size Nasıl Yardımcı Olabilirim ? " + " </p></center>";
        }
        public void Gonder(string gelen)
        {
        
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("username@hotmail.com");
            string[] email = gelen.Split('@');
            ePosta.To.Add(email[0] + "@" + email[1]);
            ePosta.IsBodyHtml = true;
            ePosta.Body= "https://meditek.net/YardimMerkezi/";
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new NetworkCredential("username@hotmail.com", "123456");
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            sc.Send(ePosta);
           
        }
        public void Bot(string gelen)
        {
            gelen = gelen.ToLower();
            string gidecekdeger = string.Empty;

            gelen = gelen.Replace(":)", "<img src = 'https://icons.iconarchive.com/icons/oxygen-icons.org/oxygen/16/Emotes-face-smile-icon.png' /> ");

            gidecekdeger += "<p style='color: green; font-family:calibri'>" + "<img src='https://icons.iconarchive.com/icons/oxygen-icons.org/oxygen/16/Actions-arrow-right-icon.png'/> &nbsp" + gelen + "</p>";


            //webBrowser1.DocumentText += " <p style='color: blue; '> ";
            if (gelen == ":)")
            {
                gidecekdeger += "<img src='https://icons.iconarchive.com/icons/oxygen-icons.org/oxygen/16/Emotes-face-smile-icon.png'/>";
            }
            else if(gelen.Contains("merhaba"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Merhaba,size nasıl yardımcı olabilirim?" + "</p>";
            }
            else if (gelen.Contains("yardım")||gelen.Contains("destek")|| gelen.Contains("hata"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Hangi konuda sıkıntı yaşıyorsunuz?" + "</p>";
            }
            else if (gelen.Contains("sistem hatası"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Daha iyi bir iletişim için e-mail adresinizi alabilir miyim?" + "</p>";
            }
            else if (gelen.Contains("mail.com"))
            {
                gidecekdeger+= "<p style='color: blue; font-family:calibri'>" + "E-posta adresiniz başarıyla alınmıştır.Destek ekibimiz sizinle en kısa sürede iletişime geçecek, lütfen beklemede kalınız." + "</p>";
                Gonder(gelen);
            }
            else if (gelen.Contains("nasılsın"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "İyiyim teşekkür ederim.Siz Nasılsınız ?" + "</p>";
            }
            else if (gelen.Contains("ürünler"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Ürünlerimiz İBYS Web, İBYS Masaüstü,İBYS Persis, İBYS Orbis, AHBS Masaüstü, AHBS Mobile, AHBS Kiosk, TBYS Web, PKD, Inkscape için Meditek, Medi Asfalt'tan oluşmaktadır. Hangisi hakkında bilgi sahibi olmak istersiniz?" + "</p>";
            }
            else if(gelen.Contains("ibys web"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "İBYS yöneticiler ile çalışanlar arasında iletişimi güçlendiren, işletmenizin tüm süreçlerine çalışanların daha etkin katılımını sağlayan yeni nesil bir yazılım çözümüdür. Mobil uyumluluğu sayesinde akıllı telefon ve tabletlerde de rahatlıkla kullanılabilir." + "</p>";
            }
            else if (gelen.Contains("ibys masaüstü"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "İSG sektörünün ilk yazılımlarından olan İBYS Masaüstü uygulaması ile, sınırsız işyeri ve çalışanı sisteme ekledikten sonra işyerlerinin bölüm bazlı risk değerlendirmelerinden yıllık çalışma planlaması yapılabilir. Acil durum tahliye planlarından eğitim sertifikalarına, İBYS bildirimlerinin yanında E reçete sistemi ile entegre çalışmanın sağladığı zaman ve efor tasarrufunun farkına varmak için sektörün en iyisi ile tanışın!" + "</p>";
            }
            else if(gelen.Contains("ibys persis")){
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Meditek İBYS PERSİS uygulaması çalışanların tekrar eden iş sağlığı ve güvenliği eğitimlerinin uzaktan verilmesi, sınava tabi tutulması ve sertifikasyon sürecinin tamamlanması için İBYS web ve masaüstü uygulamalarımızla entegre çalışan yazılım çözümüdür." + "</p>";
            }
            else if(gelen.Contains("ibys orbis"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Ortak Bilgi İzleme Sistemi (ORBİS) ile birden fazla veritabanı ve onlarca işyerinin istatistiklerini tek bir yerden yönetebilir, müşterilerinize de bu imkanı sağlayabilirsiniz. Veri güvenliği ve gizliliği baz alınarak kurulan alt yapımız sayesinde yetkilendirildiğiniz, sorumlusu olduğunuz işyerlerinin İSG faaliyetleri ile ilgili tüm detaylara tek ekrandan ulaşma imkanına sahip olun." + "</p>";
            }
            else if(gelen.Contains("ahbs masaüstü"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Aile Hekimi Bilgi Sistemi (AHBS) , eski teknolojilerden uzak, kullanıcı dostu arayüzler ile tüm işlemlerinizi kısa sürede tamamlayabilirsiniz. Sınırsız teknik destek hizmetimiz ile birlikte sorun yaşamanız durumunda dahi kısa sürede çözüldüğünü göreceksiniz." + "</p>";
            }
            else if(gelen.Contains("ahbs mobile"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Aile Hekimi Bilgi Sistemi Mobile ile Aile Sağlık Merkezi dışında özellikli izlem, performans sorgulama gibi işlemlerinizi gerçekleştirebilir, entegre çalışma özelliğini kullanarak Aile Sağlık Merkez'lerinde yapılan işlemleri eşitleyebilirsiniz." + "</p>";
            }
            else if(gelen.Contains("ahbs kiosk"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "AHBS Kiosk Hasta kabulü, ASM içerisinde misafir ve kesin kayıtlı hasta dağılımı, izin durumuna göre hasta yönlendirmesi gibi özelliklere sahip Kiosk uygulamadır. Düşük özelliklerde Windows işletim sistemine sahip cihazlarda rahatlıkla kullanabilirsiniz." + "</p>";
            }
            else if(gelen.Contains("tbys web"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Taşeron Bilgi Yönetim Sistem (TBYS) , taşeronlarla ve çalışanlarla ilgili iş süreci oluşturup uyarı, hatırlatmalarla etkili ve kolay süreç yönetimini hedefleyen web çözümüdür. Taşeronlara ve çalışanlara ait belge takibi sürecinin yönetimini kolaylaştırır." + "</p>";
            }
            else if (gelen.Contains("pkd"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "PKD 2 ile, Patlamadan Korunma Dokümanı hazırlamanızda size yol gösterecek, hesaplamalarınızı hızlandıracak ve yazdırma listelerinizi otomatik olarak düzenleyen bir uygulamadır." + "</p>";
            }
            else if(gelen.Contains("ınkspace için Meditek"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Profesyonel çizimler yapabileceğiniz INKSCAPE uygulaması için Meditek Arge olarak oluşturduğumuz sembol kütüphanesi ile Acil durum eylem planları başta olmak üzere iş sağlığı ve güvenliği ile ilgili amaca ve göze hitap eden görseller oluşturabilirsiniz. Örnek çizim kütüphanesinden bitmiş bir krokiyi seçip sadece üzerinde düzenlemeler yaparak çiziminizi daha hızlı tamamlayabilirsiniz." + "</p>";
            }
            else if(gelen.Contains("medi asfalt"))
            {
                gidecekdeger += "<p style='color':blue;font-family:calibri'>" + "Asfalt serim öncesi, sonrası ve kalite kontrol işlemlerinin raporlanması için geliştirilen mobile destekli web uygulamasıdır. Tablet ve mobile cihazlar üzerinde kolaylıkla kullanabilirsiniz. Raporlarınızın çıktısını alabilir, mail gönderimi yapabilirsiniz." + "</p>";

            }
            else if (gelen.Contains("kullanıcı girişi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + " Sisteme tarafınıza bildirilen web site linki ile giriş yapabilirsiniz. ÖRN: isg.meditekisg.com Giriş yaparken ihtiyacınız olan bilgiler; sistem yöneticisi tarafından kullanıcı kaydınız oluşturulduğunda girilmiş olan e posta adresinize mail olarak gönderilecektir. Sisteme girişte sorun yaşamanız durumunda 0 216 706 3338'i arayıp 1'i tuşlayarak çağrı merkezimize ulaşabilir, yaşadığınız sorunu kısa bir sürede giderebilirsiniz. Giriş ekranında mevcut olan parolamı sıfırla seçeneği parolanızı unutmanız durumunda sisteme kaydınız yapılırken belirlenen e posta adresinize parola sıfırlama bağlantısı gönderilerek yeni parola oluşturmanız konusunda yardımcı olacaktır. " + "</p>";
            }
            else if (gelen.Contains("iş güvenliği"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + " İş Güvenliği alanındaki sorunları detaylı izleyebilir programa girdiğiniz her veriyi anlamlı bir bilgi olarak İSG süreç akışınızı rahatlıkla oluşturabilirsiniz. " + "</p>";
            }
            else if (gelen.Contains("kullanıcı ekleme"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Kullanıcılar ekranında Yeni Ekle butonu ile sisteme yeni kullanıcı ekleyebilirsiniz. Parolanız E-Posta adresinize gönderileceğinden dolayı, E-Posta adresinizi doğru girdiğinizden emin olmalısınız. Bu ekrana Sistem Bilgisi > Kullanıcılar menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("kullanıcı grupları"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Kullanıcı Grupları adımlarıını izleyerek erişebileceğiniz bu ekranda yeni yetki grupları oluşturabilir, mevcut gruplar üzerinde düzenleme yapabilirsiniz. Kullanıcı Grubu oluştururken kullanıcılarınızın hangi modülde hangi işlemleri yapabileceğini belirleyebilirsiniz." + "</p>";
            }
            else if (gelen.Contains("kullanıcı izinleri"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Mevcut kullanıcıların izinlerini sisteme işlemek için kullanılan ekrandır. Bu ekrana Sistem Bilgisi > Kurum Bilgileri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("kurum bilgileri"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Kurum Bilgileri menüsünden, kurum bilgilerine erişip düzenleme işlemi yapabilirsiniz.Bu ekrana Sistem Bilgisi > Kurum Bilgileri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("puantaj ayarları"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Puantaj Takvimi ve İşyeri Denetimleri ekranlarında işlem yapmadan önce Puantaj Onay Ekibi atamaları ve sayısal hesaplamalar için katsayıların belirlenmesi işlemlerini bu ekrandan yönetebilirsiniz." + "</p>";
            }
            else if (gelen.Contains("genel tanımlar"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Sistem içerisinde süreçler işlenirken kullanılan verilerin türleri, örneğin; çalışan türleri, muayene türleri gibi tanımların yönetildiği ekrandır. Kolaylık olması açısından genel olarak kullanılanlar ilk kurulum esnasında hazır olarak sunulmaktadır." + "</p>";
            }
            else if (gelen.Contains("anasayfa"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "İSG Performansı, Aksiyonlar, İş Planı Özet Ekranı ve Uyarılar gibi kısa bilgilendirmelerin olduğu gösterge paneli." + "</p>";
            }
            else if (gelen.Contains("uyarılar"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Uyarılar Ekranında 6331 sayılı kanun ve alt yönetmeliklerin tamamından derlenmiş ceza maddeleri ve tutarları yer almaktadır. Kullanıcının yetkisi dahilinde görebileceği işyerlerindeki çalışmalar Meditek İBYS tarafından kontrol edilerek olası bir denetlemede karşılaşılabilecek ceza miktarlarını karşınıza çıkarmaktadır.Bu ekrana Ana menü > Uyarılar menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("işveri yönetimi"))
            {
                gidecekdeger += "<p style= 'color:blue;font-family:calibri'>" + "Bu ekranda işyeri ile ilgili tüm detaylara yetkiniz dahilinde erişebilirsiniz. işyeri yönetimi ekranında; İş yeri bilgilerini düzenleyebilir, İş yeri bilgi formu, Ceza maddeleri detayları gibi istatistikleri alabilir, Hatırlatmalar ekranı ile ilgili işyerindeki eksiklikleri görebilir, İşyeri bölümü ekleyip düzenlemeler yapabilir, İSG kurul ve çalışan temsilcilerin atamalarını yapabilir ve ilgili dokümanları çıktı alabilir, uygulamasında ilgili işyeri için yetkilendirilecek kulanıcıyı oluşturabilirsiniz.Bu ekrana Ana menü > İşyeri Yönetimi menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("insan kaynakları"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "İşyerlerinde çalışan personellerin detaylı bilgileri ile gösterildiği insan kaynakları menüsünde çalışanların özlük bilgileri, çalışma bilgileri, excellden toplu veya tek tek çalışan ekleme, işten çıkarma gibi tüm işlemleri gerçekleştirebilirsiniz. Bunun yanında çalışanları bir gruba ekleyip, periyodik muayenelerini, laboratuvar tahlillerini tehlike sınıfı gibi faktörler olmadan harici olarak takibini sağlayabilirsiniz.Bu ekrana Ana menü > İnsan Kaynakları menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("çalışan ara"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "İşyerlerinde çalışan personeller arasında gerek metin gerekse Meditek üzerinden oluşturulan QR Kodu ile arama yapıp detaylarına tıklayarak personelin takibini yapabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("organizasyon şeması"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Organizasyon şeması, stratejik yönetim dahilinde organizasyondaki hiyerarşik yapının ve ilişki zincirlerinin bir bütün olarak haritalanmasıdır. Meditek'te bu hiyerarşik yapıyı bu kısımda oluşturabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("istatistikler"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Ana menüden direk ulaşabileceğiniz istatistikler modülü, sisteme girilen veri havuzlarından oluşturulmuş onlarca istatistiği karşınıza çıkarmaktadır.Bu ekrana Ana menü > İstatistikler menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("ibys gönderimleri"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + " İBYS Gönderim zorunluluğu ile işlevsel hale getirilen bu ekranda; gerçekleştirmiş olduğunuz eğitimlerin/muayenelerin Aile, Çalışma ve Sosyal Güvenlik Bakanlığı İBYS sunucularına gönderimini ve sorgulamasını gerçekleştirebilirsiniz. Yine kullanıcı yetkisine göre verilmiş eğitim/muayene kayıtlarının görüldüğü bu ekranda e-imza cihazınız bilgisayarınızda takılı iken gönderim işlemlerini gerçekleştirebilirsiniz.Bu ekrana Ana menü > IBYS Gönderimleri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("malzeme yönetimi"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Malzeme Yönetimi, ecza dolabı için tıbbi malzeme ve Kişisel koruyucu donanımların giriş, çıkış, stoktaki durumu gibi verileri görebileceğiniz menüdür.Bu ekrana Ana menü > Malzeme Yönetimi menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("puantaj takvimi"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Açılan takvim görünümünden saha ziyaretinin gerçekleştirileceği zaman dilimi seçilerek planlama gerçekleştirilir.Planlanan ziyaretin üzerine mouse sol click ile tıklandıktan sonra karşınıza gerçekleştirme ekranı çıkacaktır. Burada Denetim detayları, denetlenecek bölüm, denetlemeye konu olan kontrol listeleri seçilir ve işlemlere devam edilir.Konu listesinden kontrol konuları seçilebileceği gibi tehlike kontrol konuları kütüphanesini de kullanarak ziyaret konuları belirleyebilirsiniz. Tespit edilen konular ile ilgil gerekli işlemler resimde gösterilmiştir." + "</p>";
            }
            else if (gelen.Contains("excelden toplu dosya yükleme"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Bu modül mevcut verilerinizi sisteme toplu girişi kolaylaştırmak amaçlıdır sadece excel formatını kabul eder.Yüklenebilecek veri türleri;İşyeri,Personel,Eğitim,Ekipman,Risk Değerlendirme,Tehlike Konuları,Periyodik Muayenedir.Verilerinizin sorunsuz yüklenmesi için şablonların doğru doldurulduğuna dikkat etmelisiniz.Bu ekrana Ana Menü > Excelden Yükle menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("risk değerlendirme"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Risk değerlendirme oluşturmak için;Yeni Kontrol Listesi Oluştur, Başka Bir Listeyi Kopyala,Excel Dosyasından Yükle, Seçeneklerini kullanabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Planla > Risk Değerlendirme menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("acil durum planı"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Bu ekranda Tatbikatlar planlayıp gerçekleştirebilir, Acil durum müdahale ekiplerini oluşturabilir, Acil durum eylem planları hazırlayabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Planla > Acil Durum Planı menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("kurumsal planlama"))
            {
                gidecekdeger += "<p style='color:blue;font-family:calibri'>" + "Kurumsal planlama ekranında yeni plan oluşturabilir, mevcut planları gerçekleştirebilir, düzenleyebilir ve firma, personel, tarih bazlı filtrelendirmeler ile seçimler yapabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Planla > Acil Durum Planı menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("yıllık çalışma planı"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Yıllık çalışma planlarınızı bu ekrandan oluşturabilirsiniz. Yıllık çalışma planı oluşturabilmek için;Çizelgeden Düzenle,Konuları Düzenle olmak üzere iki farklı yöntem kullanılabilir. Çizelgeden Düzenle seçeneğinde aşağıdaki resimde görülen modül aktif olur ve Çalışma türü karşısında bulunan aylarda seçim yaparak plan oluşturabilirsiniz.Konuları Düzenle seçeneği ile de her bir konu için ayrı ve detaylı bir planlama ekranı ile işlemleri devam ettirebilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Planla > Yıllık Çalışma Planı menüsünden ulaşabilirsiniz." + " </p>";
            }
            else if (gelen.Contains("faaliyet listesi "))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Faaliyet listesi menüsünde 6331 sayılı kanun ve buna bağlı yönetmelikler, yıllık çalışma planı, periyodik kontroller gibi onlarca kriterden oluşan iş listenizi görebilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Planla > Faaliyet Listesi menüsünden ulaşabilirsiniz. " + " </p>";
            }
            else if (gelen.Contains("eğitimler"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Eğitimler sekmesinde yapılabilecek işlemler genel hatları ile şunlardır;Hızlı eğitim planı oluşturabilir,itim kayıtları girebilir,Çalışanların eğitim durumlarını görebilir,Ayrıca eğitim takibi yapabilirsiniz.Eğitim sertifikalarını oluşturabilir ve temel eğitim belgelerinin çıktılarını alabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Uygula > Eğitimler menüsünden ulaşabilirsiniz." + " </p>";
            }
            else if (gelen.Contains("iş ekipmanları"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu ekranda iş ekipmanlarının toplu ve tek tek yüklenmesi, bakım ve periyodik kontrollerinin takip edilip kayıt altına alınması gibi bütün işlemleri gerçekleştirebilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Uygula > İş Ekipmanları menüsünden ulaşabilirsiniz. " + " </p>";
            }
            else if (gelen.Contains("ortam ölçümleri"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Ortam ölçümleri menüsünde iş yerinde gerçekleştirilecek ölçümlerin kayıtlarını tutabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Uygula > Ortam Ölçümleri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("kkd yönetimi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu ekranda personele Kişisel Koruyucu Donanım Dağıtımı yapabilir, KKD Dağıtım Listeleri, Teslim Tutanakları ve Talep listesini alabilirsiniz. Bu ekrana Ana menü > İş Güvenliği > Uygula > KKD Yönetimi menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("ramakkala olayları"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu ekranda yeni ekle butonu ile yeni ramak kala bildirimi yapabilir, daha önceki bildirimleri düzenleyebilir ve silebilirsiniz. Açılan ramak kala bildirimlerinin takibinin gerçekleştirilebilmesi için Dif kaydı oluşturabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Uygula > Ramakkala Olayları menüsünden ulaşabilirsiniz." + " </p>";
            }
            else if (gelen.Contains("işyeri ziyaretleri"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu ekranda plandışı ziyaret ekleyebilir ilgili yazıcı çıktılarını alabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Kontrol Et > İşyeri Ziyaretleri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("isg kurulu toplantıları"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Daha önce işyer ibilgilerinde girişini yaptığımız Kurul üyeleri verisinden de yararlanacağımız bu ekranda İSG kurul toplantılarının planlanması ve gerçekleştirilmesi süreçleri takip edilmektedir.Kurul toplantılarını gündem oluştur butonu ile planlayıp sonrasında gerekli tüm alanlar doldurulduktan sonra toplantı çağrı formu, toplantı tutanağı gibi yazıcı çıktılarına da bu ekrandan ulaşabilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Kontrol Et > İsg Kurul Toplantıları menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("aksiyon yönetimi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu menüde, Kurul toplantıları, RD, iş kazası gibi Dif açılabilen tüm işlemlerden oluşan kayıt kümesini görebilirsiniz.Bu ekrana Ana menü > İş Güvenliği > Kontrol Et > Aksiyon Yönetimi(DF)(Dif) menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("iş kazaları"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "SGK iş kazası bildirim formu ile aynı şekilde dizayn edilmiş lan iş kazası bildirimini sistemimizden giriş yapıp takipleri sürdürebilirsiniz.Bunun yanında iş kazası olay araştırma formu, yıllık ve aylık iş kazası istatistiklerini de bu ekrandan alabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("iş sağlığı yönetimi anasayfa"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Çalışanları kişi gruplarına ayrılmış olduğu halde görüntüleyebilirsiniz. Bunun yanında poliklinik sayılarının bulunduğu istatistik ekranı, son yapılan muayene, enjeksiyon, pansuman ve aşılar ibi verilere bu ekrandan ulaabilirsiniz. İş sağlığı ekranını yetkisi doktor olmayan kişiler göremeyecektir." + "</p>";
            }
            else if (gelen.Contains("kişi listesi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Çalışanların tamamını görüntüleyebilir, periyodik muayene ve genel sağlık muayenesi yapabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("periyoduk muayene başlatma"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Kişi listesinde ilgili kişinin sağ tarafından periyodik muayene başlat butonunu tıklayarak yeni işe giriş/ periyodik muayene başlatabilirsiniz. Bu ekranda sağ üst köşedeki hızlı doldur seçeneği; kişinin tüm bilgilerinin normal olarak işaretlenmesini sağlamaktadır." + "</p>";
            }
            else if (gelen.Contains("dsp işlemleri"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Bu ekrana Ana menü > İş Sağlığı Yönetimi > Kişi Listesi > DSP İşlemleri menüsünden ulaşabilirsiniz." + "</p>";
            }
            else if (gelen.Contains("poliklinik geçmişi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Tarih aralığı, kimlik numarası gibi kirterler ile tek tek veya toplu olarak periyodik muayene, genel sağlık muayenesi gibi tüm işlemlerin bulunduğu poliklinik geçmişini görüntülemenizi sağlar." + "</p>";
            }
            else if (gelen.Contains("randevular"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Tarih aralığı, kimlik numarası gibi kriterler ile tek tek veya toplu olarak periyodik muayene, genel İşyeri hekimi yetkili olduğu işyerlerinde randevu takvimi oluşturabilmektedir. Bu takvim oluşturulduktan sonra çalışan portalı / UZEM uygulamamızdan çalışanlar, işyeri hekiminden randevu alabilirler." + "</p>";
            }
            else if (gelen.Contains("aşı takvimi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + " Kullanım kolaylığı olması açısından aşıların tüm detayları ile görüntülenip yönetildiği ekrandır." + "</p>";
            }
            else if (gelen.Contains("meslek hastalıkları"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + " Bu ekranda meslek hastalığı olan çalışların görüntüleyebilir ve yeni meslek hastalığı bildiriminde bulunabilirsiniz.Bu ekrana Ana menü > İş Sağlığı Yönetimi > Meslek Hastalıkları menüsünden ulaşabilirsiniz." + " </p>";
            }
            else if (gelen.Contains("genel dokümanlar"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "Genel Dokümanlar modülünde Sol taraftan belge klasörünü seçtikten sonra sağ taraftan Dosya Yükle diyerek, bilgisayarınızda bulunan bir Dokümanı sisteme yükleyebilirsiniz" + " </p>";
            }
            else if (gelen.Contains("isg dokümantasyonu"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + "İSG Dokümantasyonu modülü firmaya ait belgeleri süreleriyle beraber takibini sağlayabilmek için kullanılır." + " </p>";
            }
            else if (gelen.Contains("bilgi"))
            {
                gidecekdeger += "<p style='color: blue; font-family:calibri'>" + " https://meditek.net/ internet sitemizden istediğiniz her konuda bilgiye ulaşabiirsiniz." + "</p>";
            }
            else
            {
                gidecekdeger += "<p style='color: red; font-family:calibri''>" + " " + " Üzgünüm dediğinizi anlayamadım " + "<img src='https://icons.iconarchive.com/icons/oxygen-icons.org/oxygen/16/Emotes-face-sad-icon.png'/>" + "</p>";
            }
                webBrowser1.DocumentText += gidecekdeger;
        }

       
    }
}
