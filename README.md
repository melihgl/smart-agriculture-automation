![visitor badge](https://visitor-badge.laobi.icu/badge?page_id=melihgl.AkilliTarimOtomasyonu_only=true)

I am sharing the codes of the login form and information screen I created for my _**Smart Agriculture project.**_ I will add new codes over time. _**VB.Net**_ language and _**MS SQL Server**_ were used. Thanks.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

![1](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/f86f8b7a-8757-4723-8571-58a35170e644)

_**Akıllı Tarım Otomasyonu**_ için oluşturduğum giriş formunun ve bilgi ekranının kodlarını paylaşıyorum. Zamanla yeni kodlar ekleyeceğim. _**VB.Net**_ dili ve _**MS SQL Server**_ kullandım. Projemi paylaştığım diğer web siteleri ise şunlar:

[VB.Net Kullanarak, Visual Studio’da Veri Tabanı İşlemleri Yapmak](https://medium.com/@melihgul/vb-net-kullanarak-visual-studioda-veri-taban%C4%B1-ms-sql-server-i%CC%87%C5%9Flemleri-yapmak-22f0f5f5d056) <br/>
[Try Catch Blokları Kullanarak SQL Bağlantısını Güvenli Hale Getirmek](https://medium.com/@melihgul/try-catch-bloklar%C4%B1-kullanarak-sql-ba%C4%9Flant%C4%B1s%C4%B1n%C4%B1-g%C3%BCvenli-hale-getirmek-vb-net-503c29cbc7cc) <br/>
[Melih Botanik](https://www.melihbotanik.melihgul.com/index.php/12-12-2023-te-sundugum-akilli-tarim-kodlarim)

**Kodların Nasıl Çalıştırılacağına dair Açıklama:** <br/>
Projeyi, Visual Studio'da çalıştırabilmek için, bilgisayarınızda Visual Studio'nun kaynak kodlarının bulunduğu dosyaya, yukarıdaki VB.Net dosyalarını indirmeniz gerekmektedir. Bu dosya belgelerim klasöründe ya da C'nin içinde olabilir. Veri tabanı dosyalarını da aynı şekilde MS SQL Server'ın kaynak dosyalarına atmalısınız.* <br/>
***Not:** Güvenlik endişelerim sebebiyle şimdilik veri tabanı dosyasını paylaşmıyorum.

**Çalışmamın Genel Durumu:** <br/>
Proje zamanla ilerleyecektir. İlerledikçe de, ayrıntılı dokümantasyon belgelerini sizlerle paylaşacağım. Henüz, projenin %1'i bile bitmiş değil. Yeteri kadar ilerleyebildiğimde, otomasyon için gerekli olan elektroniği satın alıp _**kendi tarlamda (Edirne - Havsa - Oğulpaşa köyünde)**_ deneyeceğim. Şu günlerde 3. formu hazırlıyorum. Bu formda, TOPRAK, ELEMENT, GÜBRE, HAVA DURUMU, SU, BİTKİ GELİŞİMİ, HASTALIK VERİLERİNİ, veri tabanından çekeceğim. 4. bir form daha oluşturup bu verilerle ilgili sonuçları da orada değerlendirebilirim. Ancak şimdilik 3. forma odaklandım.

**Çalışmamda Hedeflerim:**
- Temel CRUD işlemlerini yapabilmek.
- Tarladaki bütün değişimleri eş zamanlı olarak sensörlerden toplayıp veri tabanında tutabilmek.
- Verilerle ilgili analiz yapıp, tarlanın şimdiki ve gelecekteki sorunları hakkında çıkarımlar yapabilmek.
- Tarladan en iyi verimi alabilmek için, yazılım ve donanımsal olarak yüksek işlevli bir ürün ortaya çıkarmak.

**Giriş Formunda Yaptıklarım:**
- Veri Tabanına kayıtlı olan Kullanıcı ad ve şifrelerini, Visual Studio'da yazabilmek için gerekli SQL bağlantısını yaptım.
- Progress Bar'ın çalışması için gerekli kodları yazdım.

**1. Bilgi Formunda Yaptıklarım:**
- Veri tabanıyla bağlantı sağladım.
- Ekle, Düzenle, Temizle, Sil, Çıkış düğmelerine yazdığım kodlarla temel veri tabanı işlemlerini Visual Studio'da gerçekleştirdim.
- SQL injection'dan korunmak için try - catch blokları kullandım.

**2. Bilgi Formunda Hedefim (henüz tamamlamadım):**<br/>
Temel veri tabanı işlemlerinin yanında, eklediğim verilerle ilgili tarihsel bir sıralama yapmak. Bunu created_date ve updated_date kolonlarıyla gerçekleştireceğim. Böylece verileri analiz edebilmeyi hedefliyorum. 

**3. Bilgi Formunda Hedefim (henüz başlamadım):**<br/>
Bu formda verilerin analizini yapmaya çalışacağım. Şimdilik zihnimde bu şekilde tasarlıyorum. Nasıl yapacağımı henüz bilmiyorum. Yaptıkça burada, yaptıklarımı güncelleyeceğim.

![ge](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/74cbc9e7-bc28-4cf8-ae7f-73ec5c782d85)
![be1](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/de133e23-a079-45bf-afaa-083cda6accd9)
![Adsiz2](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/4d55c354-29ac-407e-b3b0-e1b641c07922)

Bir süre bu formun kodlarıyla ilgileneceğim. Önceki iki formun kodlarını yukarıda paylaşmıştım. Süreç biraz sezgisel ilerlese de altından kalkabileceğime inancım tam...  

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Tablolar arasındaki ilişkilerle ilgili bilgiler aşağıdadır. Bu ilişkiler ya da tablolar zamanla değişebilir. Örneğin Element ve Kullanıcı tablolarını proje ilerlerken oluşturdum. Kullandığım yazılım mimarisi **Code and Fix** olduğundan, proje bu şekilde ilerliyor. Tek başıma yaptığım bir çalışmada en uygun modelin bu olacağını düşündüm. Çünkü bu projede, benim için önemli olan **en hızlı bir biçimde projeyi çalışır hale getirmektir.** İleride yapacağım çalışmalarda daha farklı modeller kullanabilirim.<br/>
![14](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/c4ce700d-be48-4541-92e2-30483380a416)
![12](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/e734f039-475a-44ce-9cf7-9db7b0859936)
![13](https://github.com/melihgl/AkilliTarimOtomasyonu/assets/114761555/8addfaec-7b0e-4982-a3c0-392eb56549dc)

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
**KAYNAKLAR** <br/>
Son olarak, çalışmam boyunca faydalandığım, Trakya Üniversitesi Bilgisayar Programcılığı bölümünde almış olduğum dersler:
- Görsel Programlama I
- Görsel Programlama II
- Veri Tabanı ve Yönetimi
- İleri Veri Tabanı Sistemleri
- Yazılım Mimarileri
- Sistem Analizi ve Tasarımı
- Grafik ve Animasyon I (Photoshop) <br/>

Diğer derslerin de katkısı olmuştur. Ancak en çok bu derslerde öğrendiğim bilgileri kullandım. Bunun yanında hem elektronik hem de basılı farklı kaynaklardan da yararlandım. İlerleyen süreçte bu kaynakları da paylaşacağım. Şimdilik akıllı tarımla alakalı üç web sitesini burada belirtebilirim. Bu çalışmalar, konumla alakalı olarak oldukça kapsamlı, önemlidir. Zamanla onlardan faydalanmaya devam edeceğim: <br/>

[Farmery - Opensource Smart Farm Platform](https://www.hackster.io/dmtan/farmery-opensource-smart-farm-platform-adcc21) <br/>
[Libelium - Smart Agriculture](https://www.libelium.com/iot-solutions/smart-agriculture/) <br/>
[Fiware - Smart Agrifood](https://www.fiware.org/community/smart-agrifood/)
  
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

**Bu aşamaya gelebilmiş olmamı sağlayan tüm programlama bölümü hocalarıma ve bilgilerimizi paylaştığımız bölümden arkadaşlarıma teşekkür ederim. Kodlamayla kalın, iyi günler, teşekkürler.** <br/>
**Melih Gül**<br/>
<img align="left" alt="GIF" src="https://user-images.githubusercontent.com/74038190/212750999-42ff8a64-dad8-4772-9648-849968543991.gif"/>
