# MyCompanyHRManagement Mimari Dokümantasyonu

## Genel Bakış

MyCompanyHRManagement, Clean Architecture prensiplerini temel alan çok katmanlı bir mimariye sahiptir. Bu yapı, uygulamanın modülerliğini ve test edilebilirliğini artırırken, bağımlılıkları minimize eder.

## Katmanlar

1. **Domain Katmanı**
   - Temel iş mantığını ve varlıkları (entities) içerir.
   - Diğer katmanlara bağımlılığı yoktur.

2. **Application Katmanı**
   - Kullanım senaryolarını (use cases) içerir.
   - Domain katmanına bağımlıdır.
   - DTO'lar, arayüzler ve servis soyutlamaları burada tanımlanır.

3. **Infrastructure Katmanı**
   - Veritabanı işlemleri, harici servis entegrasyonları gibi teknik detayları içerir.
   - Application katmanında tanımlanan arayüzlerin somut implementasyonlarını sağlar.

4. **API Katmanı**
   - HTTP isteklerini karşılar ve yanıtlar.
   - Dependency Injection konfigürasyonu burada yapılır.

## Temel Prensipler

- Bağımlılıklar içten dışa doğrudur (Domain -> Application -> Infrastructure/API).
- Her katman sadece kendisinden bir alttaki katmana bağımlı olabilir.
- Domain ve Application katmanları, framework'lerden bağımsızdır.

## Veri Akışı

1. HTTP isteği API katmanında bir Controller tarafından karşılanır.
2. Controller, ilgili Application servisini çağırır.
3. Application servisi, gerekli Domain mantığını çalıştırır ve Infrastructure katmanındaki repository'leri kullanarak veri işlemlerini gerçekleştirir.
4. Sonuç, aynı yolu izleyerek API katmanına geri döner ve HTTP yanıtı olarak gönderilir.

## Önemli Tasarım Kararları

1. **CQRS Pattern**: Okuma ve yazma operasyonlarını ayırmak için Command ve Query nesneleri kullanılmıştır.
2. **Repository Pattern**: Veri erişim katmanını soyutlamak için kullanılmıştır.
3. **Mediator Pattern**: MediatR kütüphanesi kullanılarak uygulama içi iletişim sağlanmıştır.
4. **Validation**: FluentValidation kütüphanesi ile giriş doğrulaması yapılmaktadır.

## Güvenlik

- JWT (JSON Web Tokens) kullanılarak kimlik doğrulama ve yetkilendirme sağlanmaktadır.
- HTTPS zorunlu kılınmıştır.
- Input validasyonu her katmanda yapılmaktadır.

## Ölçeklenebilirlik

- Mikroservis mimarisine geçiş için uygun bir yapı sağlanmıştır.
- Her modül (örn. Kullanıcı Yönetimi, İzin Yönetimi) ayrı bir servise dönüştürülebilir.

Bu mimari yapı, uygulamanın bakımını kolaylaştırır, test edilebilirliği artırır ve gelecekteki değişikliklere uyum sağlamayı mümkün kılar.