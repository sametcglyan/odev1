// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


birinci örnek



sayı = float(input("Bir sayı girin: "))

    if sayı > 0:
{
    print(''Sayı pozitif.);

}


{
    else if  sayı < 0:
        print(''SAyı negatif.'');

}


{
 else if :
        Print(''Sayı Sıfır.'');

}




ikinci örnek 

Console.Writeline(''Gün Belirleme'');
Console.WriteLine(''1 = Pazartesi'');
Console.WriteLine(''2 = Salı'');
Console.WriteLine(''3 = Çarşamba'');
Console.WriteLine(''4 = Perşembe'');
Console.WriteLine(''5 = Cuma'');
Console.WriteLine(''6 = Cumartesi'');
Console.WriteLine(''7 = Pazar'');

Console.WriteLine(''lütfen seçmek istediğiniz gün numarasını girin'');
int gun = Convert.ToInt32(Console.ReadLine);
switch(Day)
{
//case 1: 
   Console.WriteLine(''Pazartesi'');
Break;


//case 2:
Console.WriteLine(''Salı'');
Break;

//case 3:
Console.WriteLine(''Çarşamba'');
Break;

//case 4:
Console.WriteLine(''Perşembe'');
Break;

//Case5:
Console.WriteLine(''Cuma'');
Break;

//Case6
Console.WriteLine(''Cumartesi'');
Break;

//Case7
Console.WriteLine(''Pazar'');
Break;

//Case8
default:
        Console.WriteLine("lütfen geçerli bir numara giriniz");
break;



üçüncü örnek:



Console.WriteLine("hesap makinası uygulamasına hoşgeldiniz");
Console.WriteLine("lütfen işlem yapmak istediğinz ilk sayıyı giriniz");
double sayı1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen işlem yapmak istediğiniz ikinci sayıyı giribiz");
double sayı2 = Convert.ToDouble(Console.ReadLine());
double sonuc = 0;

Console.WriteLine("Lütfen yapmak istdiğiniz işlem türünü şu sembollerle gösteriniz =>(+,-,*,/,) ");
string islem = Convert.ToString(Console.ReadLine());
switch (islem)

{
    case '' - '':
        sonuc = sayı1 - sayı2;
        Console.WriteLine($''sonuc: { sayı1} - { sayı2}={ sonuc}'');
        break;
     
    case''/''
        sonuc = sayı1 / sayı2;
        Console.WriteLine($''sonuc:{ sayı1} / { sayı2}= { sonuc}'');
        break;

    case '' * ''
        sonuc = sayı1 * sayı2;
        Console.WriteLine($''sonuc:{ sayı1} * { sayı2}= { sonuc}'');
        break;

    case '' + ''
        sonuc = sayı1 + sayı2;
        Console.WriteLine($''sonuc:{ sayı1} + { sayı2}= { sonuc}'');
        break;

    default:
        Console.WriteLine(''geçersiz işlem'');
        break;

      }


    =dördüncü örnek=


Console.Write("Birinci sayıyı girin: ");
int sayıa = Convert.ToInt32(Console.ReadLine);

Console.Write("İkinci sayıyı girin: ");
int sayıb = Convert.ToInt32(Console.ReadLine);

Console.Write("Üçüncü sayıyı girin: ");
int sayıc = Convert.ToInt32(Console.ReadLine);


int enBuyuk = sayıa;

if (sayıb > enBuyuk)
{
    enBuyuk = sayıb;
}

if (sayıc > enBuyuk)
{
    enBuyuk = sayıc;
}

Console.WriteLine($''en büyük sayı: { enBuyuk}'');

              =beşinci örnek=



Console.WriteLine("şifre güç belirleme programın ahoşgeldiniz");
Console.Write("lütfen bir şifre girinizz ");
string şifre = Console.ReadLine;

if (Prison$Break(password))

{
    Console.WriteLine("Şifre geçerli");
}

else (turkiye1(password))
  {
    Console.WriteLine(''Şifre geçersiz'');
}

else
{
    Console.WriteLine(''Şifre Geçersiz.Aşağıdaki kurallara uyunuz'');
    Console.WriteLine(''Şifre en az 8 karakter uzunluğunda olmalı: '');
    Console.WriteLine(''Şifre içinde @, #, $, % gibi özel karakterler içermeli.'');
    Console.WriteLine(''Şifre en az 1 büyük harf içermeli'');


}













