# 01-02-01-ism-nezo
Osztálychierarchia. UML kompozició

Rendezvényszervezés (néző osztály)

a)  
Készítse el az osztályhierarchiát az UML diagram alapján. A kódot angol nyelven írja a tiszta kód szabályainak betartásával. Adott egy enum adattípus „Statusz” néven. Adott három osztály: név, hitelkártya, bonuszkártya

A három osztálynak adottak az adattagjai és a konstruktora. A kódhoz szükséges információk az UML diagramról leolvashatók.
A Néző osztály összetett. Egy nézőnek van neve, hitelkártyája és bónuszkártyája. Ez alapján készítse el ezt az osztályt is a megfelelő konstruktorral.
Készítsen UML diagramot az elkészült kód alapján! Exportálja png formátumba!

Tesztkód:  
```
       Nev nev = new Nev("Látó","László");  
       Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");  
       DateTime dt= new DateTime(2022,3,15);  
       string dateString = dt.ToString();  
       Hitelkartya hitelkartya = new Hitelkartya("11", dt);  
       Statusz statusz = Statusz.AKTIV;  
       Bonuskartya bonuszkartya = new Bonuskartya("12", statusz, 30000);
       Nezo nezo = new Nezo(nev,hitelkartya,bonuszkartya);
```
![image](https://user-images.githubusercontent.com/6060514/133219905-0fcaee34-15ed-48ac-88d7-8e2a665438a1.png)
b)  
Az előző feladatot folytassuk a tulajdonságok meghatározásával. A legtöbb tulajdonság getelhető és settelhető kell legyen, de van ettől eltérő is. Erre figyeljen oda!
A név osztály teljes név tulajdonsága a vezetéknévből és keresztnévből kell képezni. Pl. „Látó” vezetéknév és „László” keresztnév esetén a teljes név „Látó László”!

A hitelkártya érvényes, ha az érvényesség vége az aktuális napot megelőzi!
A hitelkártya használható, ha van rajta összeg, és a kártya státusza aktív.
Készítsen UML diagramot az elkészült kód alapján! Exportálja png formátumba!

Teszkód:
*Név:*
```
Nev nev = new Nev("Látó","László");
Console.WriteLine("Tulajdonság:"+nev.TeljesNev);
```
*Hitelkártya:*
```
Hitelkartya hitelkartya = new Hitelkartya("11", dt);
if (hitelkartya.Lejart)
Console.WriteLine("Tulajdonság: a hitelkártya lejárt");
else
Console.WriteLine("Tulajdonság: a hitelkártya érvényes");
```
*Bónuszkártya:*
```
Statusz statusz = Statusz.AKTIV;
Bonuszkartya bonuszkartya = new Bonuszkartya("12", statusz, 30000);
if (bonuszkartya.Hasznalhato)
Console.WriteLine("Próba: a bónuszkártya használható");
```
![image](https://user-images.githubusercontent.com/6060514/133219469-7bb3ddfb-f880-492c-bb00-a6ea529a2e16.png)

c)  
Egészítsük ki a feladatot a ToString metódus felülírásával minden egyes osztály esetén!
Ehhez kapcsolódó tesztkód!
```
       Nev nev = new Nev("Látó","László");
       Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
       DateTime dt= new DateTime(2022,3,15);
       string dateString = dt.ToString();
       Hitelkartya hitelkartya = new Hitelkartya("11", dt);
       Statusz statusz = Statusz.AKTIV;
       Bonuskartya bonuszkartya = new Bonuskartya("12", statusz, 30000);
       Nezo nezo = new Nezo(nev,hitelkartya,bonuszkartya);
       Console.WriteLine(nezo);
```
Az  egyes osztály ToString metódusai a következő kimenetet adják.
```
Néző adatai:
A néző teljes neve: Látó László
Hitelkártya adatok:
  Kártyaszám:11
  Érvényesség vége 2022. 03. 15. 0:00:00
  A kártya nem járt le.
Bonuszkártya adatok:
 Kártyaszám:12
 Felhasználható összeg:30000 Ft
 Státusz: aktív
```
![image](https://user-images.githubusercontent.com/6060514/133220037-ce430c2d-58fb-4aac-a726-b2ae4e6ca376.png)

