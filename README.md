# Araba Fabrikası Projesi
Bu proje, bir araba fabrikasında araba üretimini simüle eden bir konsol uygulamasıdır. 
Kullanıcı, araba üretmek isteyip istemediğini belirtebilir ve ardından araba özelliklerini girebilir. Program, kullanıcıdan alınan bilgileri kullanarak araba nesneleri oluşturur ve bunları bir listeye ekler.

## Özellikler
 * Kullanıcıdan araba üretmek isteyip istemediğini sorma
 * Araba nesnesi oluşturma ve özelliklerini kullanıcıdan alma
 * Üretim tarihinin otomatik olarak atanması
 * Kapı sayısı için sayısal giriş kontrolü
 * Üretilen arabaların seri numaraları ve markalarının listelenmesi

   ## Program Akışı

    1 - Program, kullanıcıya araba üretmek isteyip istemediğini sorar. Kullanıcı "E" (evet) veya "H" (hayır) yanıtını verebilir. Büyük/küçük harf duyarlılığı yoktur.

    2 - Eğer kullanıcı "E" yanıtını verirse, program yeni bir Araba nesnesi oluşturur ve kullanıcıdan aşağıdaki bilgileri ister:
   
    * Seri Numarası
    * Marka
    * Model
    * Renk
    * Kapı Sayısı ( sadece sayısal değer olarak kabul edilir )

   3 - Kapı sayısı için geçersiz bir giriş yapılırsa, kullanıcıya hata mesajı gösterilir ve tekrar giriş yapması istenir.
   
   4 - Kullanıcı "H" yanıtını verirse, program sonlanır ve üretilen arabaların seri numaraları ve markaları ekrana yazdırılır.
   
