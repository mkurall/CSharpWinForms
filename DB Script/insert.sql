USE [btk_kurs_db]
GO
/*Bu sorgu TblKullanicilar tablosuna yeni kay�t ekler ve
ekledi�i kayd�n id sini getirir*/
INSERT INTO TblKullanicilar
           (Ad,Soyad,EPosta,Parola)
     VALUES ('Hasan','Can','hasan@pinar.com',1234); SELECT @@IDENTITY
GO


