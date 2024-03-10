USE [btk_kurs_db]
GO
/*Bu sorgu TblKullanicilar tablosuna yeni kayýt ekler ve
eklediði kaydýn id sini getirir*/
INSERT INTO TblKullanicilar
           (Ad,Soyad,EPosta,Parola)
     VALUES ('Hasan','Can','hasan@pinar.com',1234); SELECT @@IDENTITY
GO


