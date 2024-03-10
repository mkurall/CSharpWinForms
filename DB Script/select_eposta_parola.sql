/*Bu sorgu TblKullanicilar tablosundan belirtilen alanlarla
birlikte eposta ve parola sorgusu yapar*/
SELECT Id, Ad, Soyad, EPosta, Parola
  FROM TblKullanicilar 
  WHERE EPosta = 'mustafakural@outlook.com' and Parola='1234'

GO


