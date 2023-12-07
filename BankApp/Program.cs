using BankApp;

Bank b = new();


Istifadeci i1 = new Istifadeci();
i1.Ad = "A";
i1.Soyad = "B";
i1.MobilNomre = "dadsa";

Istifadeci i2 = new Istifadeci();
i2.Ad = "C";
i2.Soyad = "D";
i2.MobilNomre = "daDSADASDdsa";

Istifadeci i3 = new Istifadeci();
i3.Ad = "E";
i3.Soyad = "F";
i3.MobilNomre = "KSKSJDASDdsa";


b.IstifadeciElaveEt(i1);
b.IstifadeciElaveEt(i2);
b.IstifadeciElaveEt(i3);




