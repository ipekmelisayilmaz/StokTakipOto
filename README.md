# **Stok Takip Otomasyonu**

Bu proje, **C#**, **ADO.NET** ve **MSSQL** teknolojileri ile geliştirilmiş bir stok takip otomasyonudur. Uygulama, ürün, müşteri, satış ve kategori verilerinin yönetilmesini sağlar. Kullanıcılar, ürün ekleme, güncelleme, satış işlemleri ve stok durumunu takip edebilir. Stok seviyesi belirlenen bir eşik değerin altına düştüğünde uyarı sistemi devreye girer  ayrıca silinen kayıtlar listelenip geri getirilebilir. 

## **Özellikler**

- Ürün, müşteri, satış ve kategori ekleme, güncelleme, silme işlemleri.
- Stok seviyesi kontrolü ve uyarı sistemi.
- Silinen kayıtların listeleme ve geri getirme işlemleri.
- MSSQL veritabanı ile veri yönetimi.

## **Kurulum**

1. **Proje Deposu**: Bu projeyi bilgisayarınıza klonlayın:
    ```bash
    git clone <https://github.com/ipekmelisayilmaz/StokTakipOto.git>
    ```

2. **Visual Studio**'yu açın ve `StokTakipOto.sln` dosyasını yükleyin.

3. **Veritabanı Ayarları**: MSSQL üzerinde veritabanını oluşturun ve gerekli bağlantı ayarlarını `app.config` veya `settings` dosyasına ekleyin.

4. **Bağımlılıklar**: Proje için gerekli olan bağımlılıkları ve kütüphaneleri yükleyin.

## **Kullanım**

1. Uygulama açıldıktan sonra ana formdan ürün, satış, müşteri ve kategori işlemlerine erişebilirsiniz.
2. Stok seviyesi kontrolü ve uyarılar, stok miktarı belirlenen eşik değerin altına düştüğünde görüntülenir.
3. Silinen veriler, geri getirme formu üzerinden listelenip geri yüklenebilir.

 ## **Uygulamaya Ait Bazı Görseller**

![frmMain](https://github.com/user-attachments/assets/86c368da-7bd4-4670-a25a-8ec5d34f2070)


![frmSilinenler](https://github.com/user-attachments/assets/1919e0f3-a5ff-4cc7-a26a-7c1d3b79aabd)


![frmStokEkleme](https://github.com/user-attachments/assets/0ca6c3e8-1b85-4191-88c4-d64ed356d84a)

![frmUyari](https://github.com/user-attachments/assets/56b8964e-2858-445e-bff2-4207ce28bb31)
![frmÜrünListesiFiltreleme](https://github.com/user-attachments/assets/9c0ca06c-ab24-46e0-8711-b5b1518fa0ab)
![frmSatis](https://github.com/user-attachments/assets/38ac61a8-b5bf-498f-bc27-88bd6a49d9f8)

![frmSatisListesi](https://github.com/user-attachments/assets/4d70eb73-6faf-4692-8a43-f164ab8d34ef)
