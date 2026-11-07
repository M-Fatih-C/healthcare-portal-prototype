# Healthcare Portal UI Prototype

Doktor paneli, kayıt/giriş ekranları ve sağlık hizmeti odaklı sayfa tasarımlarını
gösteren ASP.NET Core MVC arayüz prototipi.

## İçerik

- ASP.NET Core MVC sayfa yapısı
- Doktor paneli ve ortak dashboard düzeni
- Kayıt ve giriş ekranı prototipleri
- Responsive HTML/CSS bileşenleri
- Statik görsel kaynaklar

## Çalıştırma

```bash
dotnet restore
dotnet run
```

Bu sürüm yalnızca arayüz gösterimidir. Eski projede referans verilen fakat
arşivde bulunmayan veri erişimi, DTO ve iş katmanları kaldırılmıştır. Kimlik
doğrulama akışı gerçek bir güvenlik sistemi olarak kullanılmamalıdır.

## Güvenlik notu

Depoda bağlantı dizesi, kullanıcı parolası veya gerçek sağlık verisi bulunmaz.
Üretim kullanımı için ASP.NET Core Identity, güvenli veri deposu, yetkilendirme
politikaları ve kapsamlı giriş doğrulaması ayrıca uygulanmalıdır.

