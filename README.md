# PI20-014 Apoteka
mentor: Zlatko Stapić

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG      | Github korisničko ime
------------  | ------------------- | ---------- | ---------------------
Marija Arki   | marki@foi.hr        | 0016130365 | mararki
Petra Banić   | pbanic@foi.hr       | 0016131752 | pbanic
Erik Baukovac | ebaukovac@foi.hr    | 0016133052 | ErikBaukovac

## Opis domene
Projekt će se bazirati na radu apoteke. Apoteka će imati centraliziranu bazu podataka. Korisnik će moći naručiti lijekove online i doći ih fizički kupiti.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F00 | Upravljanje tvrtkama | Omogućiti prodaju aplikacije različitim tvrtkama od koje svaka ima jednu ili više apoteka u svom vlasništu. Svakoj tvrtci se kreira po jedan master administrativni račun kojim se provode dolje popisane funkcionalnosti. | Arki
F0A | Administriranje | Master administrator kreira vlastite apoteke te upravlja ostalim podacima te tvrtke (npr. podacima zaposlenika). | Arki
F01    | Registracija i prijava | Aplikacija ima tri uloge Administratora (Registracija novih zaposlenika, unos, ažuriranje i brisanje lijekova u sustavu, kreiranje opcija loyalty programa kupaca), Zaposlenik (Pristup pregledu podataka i ažuriranju stanja, kreiranje i storniranje računa i kreiranje loyalty kartice kupca) i Korisnika (Rezervacija lijekova, online registracija pomoću loyalty kartice)  | Banić
F02    | Unos, ažuriranje i brisanje podataka o lijekovima  | Administrator ima ovlasti unosa podataka o lijekovima koji su dostopni za kupnju te njihovo ažuriranje i brisanje. Zaposlenici imaju pravo pregleda i ažuriranja podatka lijekova (automatsko smanjenje količine )  | Baukovac
F03    |  Unos, ažuriranje i brisanje podataka o zaposlenicima i dobavljačima | Administrator je ovlašten za unos, ažuriranje i brisanje podataka o zaposlenicima i dobavljačima. Zaposlenici bi isključivo bili u mogućnosti vidjeti osnovne podatke o dobavljačima (naziv, adresa, telefonski broj, OIB), dok pristup podacima o zaposlenicima ne bi bili u mogućnosti vidjeti  | Baukovac
F04    | Kreiranje, izdavanje, pregled i storniranje računa  | Svaki zaposlenik koji ima pristup sustavu može kreirati, izdavati, stonirati i pregledati račune . Kod prodaje lijekova potrebno je uzeti u obzir loyalty pogodnosti. Računi se ne brišu jer svi podaci o njima trebaju biti evidentirani u sustavu | Arki
F05     | Izrada loyalty kartice | Zaposlenik ima mogućnost izrade loyalty kartice odnosno unos, pregledavanje i ažuriranje podataka o kupcima | Banić
F06    | Izrada članskih opcija  | Administrator ima mogućnosti izrade, ažuriranja i brisanja članskih opcija koje se koriste kod izrade loyalty kartice | Banić
F07    | Rezervacija lijekova  | Korisnik ima mogućnost prijave u sustav, ako je prije toga izradio loyalty kartice. Korisnik ima mogućnost rezervirati lijek online koji kasnije može fizički preuzeti. Ako lijek nije dostupan, sustav će korisniku automatski poslati mail čim lijek postane dostupan | Baukovac
F08    | Nabava lijekova  | Zaposlenici su zaduženi za izradu narudžbenice, a potom i primke na temelju otpremnice dobivene od dobavljača te se ona izrađuje prilikom zaprimanja novog lijeka kako bi podaci bili vidljivi u sustavu. Ako lijek ne postoji u sustavu, zaposlenik unosi podatke o njemu  | Baukovac
F09 | Izvješća | Izraditi izvješća s tabličnim i graf prikazima o kupcima (loyalty karticama), prometu, lijekovima i slično. Izvješća je potrebno spremiti u PDF i omogućiti ispis. | Arki
F10 | Obavijest | Aplikacija automatski šalje e-mail podsjetnike klijentima o svim rezervacijama lijekova koji su stigli toga dana. Potrebno implementirati kao windows servis koji admin apoteke može upaliti ili ugasiti. | Banić
F11 | Analiza | Sustav svako jutro automatski šalje mail sa popisom lijekova kojih će nestati na zalihama u sljedećih N dana (7 <= N <= 30, podesivo u sustavu). Izračun se temelji na projekciji buduće prodaje temeljem podataka o prodaji u prethodnih M dana (30 <= M <= 90, podesivo u sustavu) | Baukovac


## Tehnologije i oprema

Naziv alata  | Primjena
------ | ----------- 
Microsoft Visual Studio | Izrada koda
Microsoft Project | Project Management
GitHub | Repozitorij koda
DataGrip | Izrada baze podataka
Microsoft Office | Izrada dokumentacije 
Visual Paradigm | Izrada ER modela
