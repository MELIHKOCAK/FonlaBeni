# 🚀 FonlaBeni - Domain Business Flow



Bu döküman, FonlaBeni Projensinin Veri Tabanı Stratejisini Açıklar.


## 1. İlişkisel Veri Tabanı(PostgreSQL)

- FonlaBeni projesinde ilişkisel veri tabanı olarak ücretsiz ve açık kaynak olmasından dolayı PostgreSQL seçilmiştir.

- FonlaBeni projesinin ilişkisel veri tabanı local ortamda kurulup çalıştırılacaktır, projede cloud tercih edilmeyecektir.

- FonlaBeni projesinde CQRS pattern uygulandığı için veri tabanları READ ve WRITE olarak fiziksel olarak ikiye ayrıldı.

- FonlaBeni projesinde veri tutarlılığı Event Driven Update stratejisi ile veri tabanı seviyesinde triggerlar üzerinden sağlanacaktır.

## 2. İlişkisel Olmayan Veri Tabanı(Redis)

- FonlaBeni projesinde verilerin okunmasını hızlandırmak amacı ile belirlenen use-case senaryolarında cacheleme yapmak için Redis kullanılacaktır.
