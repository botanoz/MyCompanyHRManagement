# MyCompanyHRManagement

MyCompanyHRManagement, şirketlerin insan kaynakları (İK) süreçlerini yönetmelerine yardımcı olan kapsamlı bir uygulamadır.

## Özellikler

- Kullanıcı Yönetimi (çalışanlar ve yöneticiler)
- İzin Yönetimi
- Puantaj ve Zaman Yönetimi
- Performans Yönetimi
- Vardiya Yönetimi
- Maaş ve Özlük İşlemleri
- Şirket ve Abonelik Yönetimi

## Teknolojiler

- Backend: C# ve .NET 
- ORM: Entity Framework Core
- Authentication: JWT
- API Dokümantasyonu: Swagger
- Loglama: Serilog
- Validation: FluentValidation
- Unit Testing: xUnit, Moq, FluentAssertions

## Kurulum

1. Repoyu klonlayın:
   ```
   git clone https://github.com/botanoz/MyCompanyHRManagement.git
   ```

2. Proje dizinine gidin:
   ```
   cd MyCompanyHRManagement
   ```

3. Bağımlılıkları yükleyin:
   ```
   dotnet restore
   ```

4. Veritabanını oluşturun:
   ```
   dotnet ef database update
   ```

5. Uygulamayı çalıştırın:
   ```
   dotnet run --project MyCompanyHRManagement.API
   ```

## API Kullanımı

API dokümantasyonuna `http://localhost:5000/swagger` adresinden erişebilirsiniz.

## Testleri Çalıştırma

```
dotnet test
```

## Katkıda Bulunma

1. Bu repoyu fork edin
2. Yeni bir özellik branch'i oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Bir Pull Request oluşturun

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## İletişim

Proje Sahibi - [@yourgithub](https://github.com/yourgithub)

Proje Linki: [https://github.com/botanoz/MyCompanyHRManagement](https://github.com/botanoz/MyCompanyHRManagement)