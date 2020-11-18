# FreshFruit
Aplikasi sederhana tentang banyaknya buah yang bisa dimasukkan ke dalam keranjang, jika keranjang penuh maka kita tidak bisa lagi manambahkannya.

## Scope & Functionalities
* User dapat mengklik tombol
* User dapat melihat gambar
* User juga dapat menambahkan buah ke dalam list sesuai kapasitas

## Tugas
1. Fungsi dari `BucketEventListener`?
Sebagai tempat untuk handle event ketika action dijalankan berhasil (onSucceed) atau gagal (onFailed).
2. Class Diagram
E:\MATKUL\Semester 3\PEMPROGRAMAN LANJUT\Modul4\FreshFruit\FreshFruit\ClassDiagram.jpg
3. Pembahasan Alur dan Logika Pemprograman
Ada beberapa class yaitu `Fruit.cs`, `Seller.cs`, `Bucket.cs`,`BucketController.cs`, dan `BucketEventListener.cs`. 
`Fruit.cs` digunakan untuk menampung macam buah, kemudian pada `Seller.cs` digunakan untuk mengatur seller apakah dia akan menambah ataupun menghapus buah dari keranjang,  
dia mengambil dari class `BucketController.cs` kemudian `Bucket.cs` yang mengatur banyaknya kapasitas dan menjadikan list buah yang ditambahkan.
Selanjutnya pada bagian `BucketEventListener.cs` digunakan untuk memberi peringatan apakah berhasil menambahkan atau tidak.
