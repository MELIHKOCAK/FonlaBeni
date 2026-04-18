# 🚀 FonlaBeni - Domain Business Flow



Bu döküman, sistemdeki temel iş akışlarını ve "Domain" katmanındaki durum (state) geçişlerini açıklar.



## 1. Proje Yaşam Döngüsü (Project Life Cycle)

Bir projenin oluşturulmasından fonlanmasına kadar geçen süreçteki durumları:



- **Draft (Taslak):** Kullanıcı projeyi oluşturdu ancak henüz onaya göndermedi.

- **Pending (Onay Bekliyor):** Admin onayı için sırada.

- **Active (Yayında):** Fon toplanmaya başlandı.

- **Funded (Hedefe Ulaşıldı):** Hedef tutar toplandı, ancak süre devam ediyor olabilir.

- **Completed (Tamamlandı):** Süre bitti ve para transferi gerçekleşti.

- **Expired (Süresi Doldu):** Süre bitti ama hedefe ulaşılamadı.







## 2. Bağış Akışı (Funding Flow)

[Okuyucu] -> (Projeyi İnceler) -> [Ödeme Yapar] -> [Proje Sahibi]



Bir kullanıcı bağış yaptığında gerçekleşen atomik işlemler:



1. **Validation:** Kullanıcının bakiye kontrolü ve projenin `Active` olup olmadığı kontrol edilir.

2. **First Process:** Destekçiden para çekilir.

3. **Second Process:** Kullanıcının hesabına para aktarılır

4. **Project Update:** Projenin `CurrentAmount` değeri güncellenir.

5. **Event Trigger:** Eğer hedef tutar geçildiyse proje tamamlandı olarak güncellenir.



## 3. Kurallar ve Kısıtlamalar (Invariants)

- Bir kullanıcı kendi projesine bağış yapamaz (**Business Rule**).

- Süresi dolmuş bir projeye bağış kabul edilemez.

- `Draft` durumundaki bir proje listelenemez.

