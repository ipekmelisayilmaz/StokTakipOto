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
    git clone <repo-url>
    ```

2. **Visual Studio**'yu açın ve `StokTakipOto.sln` dosyasını yükleyin.

3. **Veritabanı Ayarları**: MSSQL üzerinde veritabanını oluşturun ve gerekli bağlantı ayarlarını `app.config` veya `settings` dosyasına ekleyin.

4. **Bağımlılıklar**: Proje için gerekli olan bağımlılıkları ve kütüphaneleri yükleyin.

## **Kullanım**

1. Uygulama açıldıktan sonra ana formdan ürün, satış, müşteri ve kategori işlemlerine erişebilirsiniz.
2. Stok seviyesi kontrolü ve uyarılar, stok miktarı belirlenen eşik değerin altına düştüğünde görüntülenir.
3. Silinen veriler, geri getirme formu üzerinden listelenip geri yüklenebilir.
