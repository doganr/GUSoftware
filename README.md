# GUSoftware

## Proje bağımlılıkları:
- FirebaseAuthentication.net
- FirebaseDatabase.net
- FirebaseStorage.net

ilgili bağımlılıkları https://github.com/step-up-labs ekibinin kütüphanelerinden temin edebilirsiniz.

## config.xml dosyası
Kodların FireBase ortamı ile haberleşebilmesi için proje dizininde config.xml isimli firebase bağlantı bilgilerinin tutulduğu configuration dosyasını manual olarak oluşturmalısınız.
Örnek şablon:
```
<?xml version="1.0" encoding="utf-8" ?>

<FireBase>
	<AuthDomain>domain_bilginiz</AuthDomain>
	<FBDomain>fbase domain_bilginiz</FBDomain>
	<FSDomain>fstorage domain_bilginiz</FSDomain>
	<ApiKey>api_keyiniz</ApiKey>
</FireBase>
```
