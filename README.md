![Banner](Documentation/Images/Banner.png)

Project RPG Game dengan sistem multiplayer menggunakan UGS

Sistem Lobby - Host





Dibuat dengan & Menyertakan Utilitas untuk Netcode for GameObjects





Boss Room adalah game RPG multiplayer kooperatif yang berfungsi penuh, dibuat menggunakan Unity Netcode. Ini adalah sampel edukasi yang dirancang untuk menunjukkan pola netcode umum yang sering ditemukan pada game multiplayer serupa.






Ikhtisar Sampel Boss Room

Boss Room dirancang untuk digunakan secara utuh guna membantu Anda menjelajahi konsep dan pola di balik alur game multiplayer; seperti kemampuan karakter, animasi casting untuk menyembunyikan latensi (latency-masking), objek yang direplikasi, RPC, serta integrasi dengan layanan Multiplayer Services sessions dan Authentication.

Anda dapat menggunakan proyek ini sebagai titik awal referensi untuk game Unity Anda sendiri atau menggunakan elemen-elemennya secara terpisah.






💡 Paket Utilitas

Repositori ini juga berisi paket Utilities yang berisi skrip sampel yang dapat digunakan kembali. Anda dapat menginstalnya menggunakan entri file manifest berikut:





"com.unity.multiplayer.samples.coop": "https://github.com/Unity-Technologies/com.unity.multiplayer.samples.coop.git?path=/Packages/com.unity.multiplayer.samples.coop",

Untuk informasi lebih lanjut tentang aspek seni Boss Room, lihat ART_NOTES.md.





Membuka proyek untuk pertama kalinya

Setelah Anda mengunduh proyek, ikuti langkah-langkah di bawah ini untuk memulai:

Pastikan Anda telah menginstal versi editor LTS terbaru.

Sertakan dukungan standalone untuk Windows/Mac dalam instalasi Anda.

Tambahkan proyek ke Unity Hub dengan mengklik tombol Add dan arahkan ke folder root dari proyek yang telah diunduh.

Catatan: Saat pertama kali membuka proyek, Unity akan mengimpor semua aset, yang akan memakan waktu lebih lama dari biasanya.

Klik tombol Play. Anda kemudian dapat menjadi host untuk game baru atau bergabung dengan game yang sudah ada menggunakan antarmuka (UI) dalam game.







Menjelajahi proyek

BossRoom adalah pengalaman game RPG co-op delapan pemain, di mana para pemain berkolaborasi untuk melawan imp, lalu bos. Pemain dapat memilih di antara berbagai kelas yang masing-masing memiliki skill dengan karakteristik jaringan yang menarik secara didaktik. Model kontrol menggunakan click-to-move, dengan skill yang dipicu melalui tombol tetikus (mouse) atau hotkey.

Salah satu dari delapan klien bertindak sebagai host/server. Klien tersebut akan menggunakan pendekatan komposisional sehingga entitasnya memiliki komponen server sekaligus klien.

Game ini bersifat server-authoritative, dengan animasi penyamaran latensi (latency-masking).

Pembaruan posisi dilakukan melalui NetworkTransform yang menyinkronkan posisi dan rotasi.

Kode diatur dalam assembly berbasis domain. Lihat file dokumentasi arsitektur Boss Room untuk detail lebih lanjut.






Mendaftarkan proyek dengan Unity Gaming Services (UGS)

Boss Room memanfaatkan beberapa layanan dari UGS untuk memfasilitasi konektivitas antar pemain. Untuk menggunakan layanan ini di dalam proyek Anda, Anda harus membuat organisasi di dalam Unity Dashboard. Jika tidak, Anda tetap dapat menggunakan Boss Room tanpa UGS.







Pengujian Multiplayer

Untuk melihat fungsi multiplayer beraksi, kita dapat menjalankan beberapa instans game secara lokal di komputer Anda — menggunakan Multiplayer Play Mode atau build — atau memilih untuk terhubung dengan teman melalui internet. Lihat cara menguji untuk info lebih lanjut.






Pengaturan Multiplayer Lokal

Pertama, buat sebuah executable dengan mengklik 'File/Build Settings' di menu bar, lalu klik 'Build'.



Setelah build selesai, Anda dapat meluncurkan beberapa instans dari executable yang telah dibuat untuk menjadi host sekaligus bergabung ke dalam game. Saat menggunakan beberapa instans secara lokal, Anda harus menyetel profil yang berbeda untuk setiap instans demi keperluan autentikasi, dengan menggunakan tombol 'Change Profile'. 



💡 Pengguna Mac: Untuk menjalankan beberapa instans dari aplikasi yang sama, Anda perlu menggunakan baris perintah (command line). Jalankan open -n BossRoom.app

Multiplayer Melalui Internet

Untuk bermain melalui internet, buatlah terlebih dahulu executable yang dibagikan ke semua pemain — seperti di atas.

Dimungkinkan untuk terhubung antara beberapa instans dari executable yang sama ATAU antara executable dan editor yang membuatnya.

Menjalankan game melalui internet saat ini memerlukan pengaturan relay.

Pengaturan Layanan Multiplayer (Multiplayer Services Setup)

Boss Room menggunakan Paket Layanan Multiplayer (Multiplayer Services Package) untuk mengintegrasikan Sessions untuk mengelompokkan dan menghubungkan pemain.

Sebagai alternatif, Anda dapat menggunakan Port Forwarding. Situs https://portforward.com/ memiliki panduan tentang cara mengaktifkan port forwarding pada sejumlah besar router.

Boss Room menggunakan UDP dan membutuhkan port eksternal 9998 agar terbuka.

Pastikan alamat host Anda mendengarkan pada 0.0.0.0 (127.0.0.1 hanya untuk pengembangan lokal).
