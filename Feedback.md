## UVID U PROJEKT

## Uvod
* Čestitam vam na do sada odraženom poslu. Vidi se da ste posebnu pozornost posvetili dokumentaciji i da ste u nju uložili puno truda. Većina komentara ispod ne zahtjeva suštinske već najčešće strukturne promjene pa mislim da ih neće biti teško implementirati.

## Projektna dokumentacija
* Vodopadni model razvoja - Kratko ste naveli koji model planirate koristiti, ali niste naveli referencu na autora modela niti na upute kako se taj model provodi. 
* Projektni plan: Nije usuglašen sa SDLC modelom razvoja.
* Lijepo ste napravili izračun troškova, i pretpostavljam da iza navedenih cijena stoji i detaljna kalkulacija. Mogu li vas zamoliti da u dokumentaciju stavite barem dio o opterećenju članova tima (workload u satim). 
* Ponuda naručitelju je za svaku pohvalu. Vjerujem da ste preuzeli znanje s UIU-a. Bravo!

## Tehnička dokumentacija
* Pohvalno je što ste tražili i pokušali primijeniti predloške / primjere dobre prakse u raspisu dijela dokumentacije. Pri korištenju predložaka treba biti oprezan, jer ako poglavlja i teme koje se navode a nisu važne za vaš projekt možete ih izostaviti ili grupirati. Time bi se izbjegla rascjepkanost dokumenta u mnošvo poglavlja od po jednu-dvije rečenice. Isto tako postoje poglavlja koja se po svojoj prirodi mogu spojiti.
* Naziv poglavlja "IEEE" nije prikladan. Ako ste htjeli reći da je dokumentaicja pisana po IEEE standardu, onda se to obično navede kao napomena u u vodu ili footnota. 
* Po modelu podataka vidim da ste uistinu detaljno razradili funkcionalnosti projekta. Posebno mi se sviđa temporalna komponenta modela. Bravo! 
* Model klasa nije potpun i bolje bi bilo da ste dijelove modela klasa stavili u raspis dizajna svake funkcionalnosti ili teme od interesa.
* UC dijagram: Na vašim dijagramima niste koristili koncept granica sustava koji se obvezno koristi. Isto tako, postoji učensik Baza podataka čija mi uloga nije jasna. Vodite se činjenicom da učesnik mora biti samostalan pokretač izvršenja određenih radnji pomoću sustava. DB bi mogao biti actor ako bi ste programirali kao agenta koji jedanput ili više puta dnevno samostalno obavlja neke zadatke.
* AD: Sintaksički ispravni. Semantiku ćemo provjeravati na obrani.
* SD: Stereotip sustava je obično prvi objekt s kojim korisnik vrši interakciju. Iza njega su controlni i granični objekti. Kod vas nema sustava.
* Poglavlja koja se odnose na dizajn funkcionalnosti popratiti jednostavnim tekstom. Ne pretjerivati sa količinom teksta, ali isto tako ne izbjegavati tekst u potpunosti.
* Semantiku i usklađenost svih dijagama ćemo provjeravati na obrani.
* Dizajn korisničkog sučelja: Nije rađen u fazi dizajna.
* U dokumentaciju dodati poglavlje s uputama za podešavanje razvojne i produkcijske okoline te s podacima o testiranju programa (npr. korisnička imena i lozinke).
* Svako poglavlje (podpoglavlje) dokumentacije bi trebalo imati potpisanog autora (odgovornog studenta).

## Implementacija
* Pronašao sam programski kod u tri različita projekta. Čini se da je svaki član tima radio na odvojenom projektu koji je smješten u odvojenoj mapi. 
* VAŽNO: Prilikom verzionirnaja, bez obzira na funkcionalnost koja se programira i bez obzira na granu na kojoj se nalazite, programski kod uvijek ima ISTU ishodišnu mapu (u našem slučaju je to mapa Softver) i u njoj se nalazi sln dokument (rješenje) te najčešće po jedna mapa za svaki projekt od kojeg se rješenje sastoji. Vi ste imali više projekata, ali i više rješenja. To nije dobro. Dakle, rješenje mora biti jedno, a projekata može biti više. Međutim podjela na različite projekte treba biti promišljena.
* Trenutno implementirani programski kod sadrži samo dizajn korisničkog sučelja.
* Verzioniranje - Molim vas da osigurate da se odmah nakon povlačenja repozitorija programski kod može kompajlirati i pokrenuti, a da se pri tome ne zaprlja repozitorij. To znači da morate verzionirati sve fajlove koje Visual Studio ne kreira sam, a one koje kreira sam morate ignorirati pomoću odgovarajuće .gitignore datoteke. Isto tako, molim vas da pokušate primijeniti feature-branch workflow koji je opisan ovdje: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow.
* Implementirane funkcionalnosti - Ne mogu biti zadovoljan do sada implementiranom funkcionalnosti.

## Ostalo
* Home stranica vaše dokumentacije može sadržavati podatke iz prijave projekta ili sami možete odlučiti što staviti na tu stranicu koja je osobna iskaznica projekta, tima i dokumentacije.
* U dokumentaciji bi bilo dobro složiti da se klikom na sliku ista slika otvori u full screen prikazu.
* Pazite na minimalne zahtjeve za programske proizvode prije nego što pristupite obrani (npr. izdvajanje jednog dijela projekta u dll).

## Bodovi
P1: 12 bodova

---
---

## Opća povratna informacija
Projektna prijava se **prihvaća uz elemente dopune** koje navodim u nastavku. Projektna ideja je GRANIČNO u skladu sa zahtjevima kolegija. Stoga, samo implementacijom konačnog seta funkcionalnosti (nadopunjeno) studenti će moći postići sve ishode učenja na kolegiju. Budući da niste definirali odgovornosti članova tima, podjelu po ulogama sam napravio i navodim ju, zajedno sa dopunom funkcionalnosti, u tablici ispod. Molim da temeljem ovih informacija sami dopunite vašu projektnu prijavu.

## Izmjena naziva projekta
Molim vas da umjesto obrade teme **videoteke**, obradite temu **apoteke**.

## Arhitektura baze
Također molim da arhitektura sustava bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno. Ovaj zahtjev treba uzeti u obzir kao aspekt kroz dizajn i implementaciju ostalih funkcionalnosti (npr. da se ne dogodi da dva klijenta unajme istu sobu ako rade rezervaciju u isto vrijeme). 

## Konačan popis funkcionalnosti i uloge članova tima

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
**F00** | **Upravljanje tvrtkama** | **Omogućiti prodaju aplikacije različitim tvrtkama od koje svaka ima jednu ili više apoteka u svom vlasništu. Svakoj tvrtci se kreira po jedan master administrativni račun kojim se provode dolje popisane funkcionalnosti.** | **Arki**
**F0A** | **Administriranje** | **Master administrator kreira vlastite apoteke te upravlja ostalim podacima te tvrtke (npr. podacima zaposlenika).** | **Arki**
F01    | Registracija i prijava | Aplikacija ima tri uloge Administratora (Registracija novih zaposlenika, unos, ažuriranje i brisanje ~~filmova~~ **lijekova** u sustavu, kreiranje opcija ~~članarina~~ **loyalty programa kupaca**), Zaposlenik (Pristup pregledu podataka i ažuriranju stanja, sto**r**niranje računa i kreiranje članske iskaznice kupca) i Korisnika (Rezervacija ~~filmova~~ **lijekova**, online registracija pomoću članske iskaznice)  | **Banić**
F02    | Unos, ažuriranje i brisanje podataka o ~~filmovima~~ **lijekovima**  | Administrator ima ovlasti unosa podataka o ~~filmovima~~ **lijekovima** koji su dostopni za ~~posudbu~~ **kupnju** te njihovo ažuriranje i brisanje. Zaposlenici imaju pravo pregleda i ažuriranja podatka ~~posuđenih filmova~~ **lijekova** (automatsko smanjenje količine )  | **Baukovac**
F03    |  Unos, ažuriranje i brisanje podataka o zaposlenicima i dobavljačima | Administrator je ovlašten za unos, ažuriranje i brisanje podataka o zaposlenicima i dobavljačima. Zaposlenici bi isključivo bili u mogućnosti vidjeti osnovne podatke o dobavljačima (naziv, adresa, telefonski broj, OIB), dok pristup podacima o zaposlenicima ne bi bili u mogućnosti vidjeti  | **Baukovac**
F04    | Kreiranje, izdavanje, pregled i storniranje računa  | Svaki zaposlenik koji ima pristup sustavu može kreirati, izdavati, stonirati i pregledati račune ~~za izradu članske iskaznice~~. **Kod prodaje lijekova potrebno je uzeti u obzir loyalty pogodnosti (vidi F06)** Računi se ne brišu jer svi podaci o njima trebaju biti evidentirani u sustavu | **Arki**
F05     | Izrada ~~članske iskaznice~~ **loyalty kartice** | Zaposlenik ima mogućnost izrade ~~članske iskaznice~~ **loyalty kartice** odnosno unos, pregledavanje i ažuriranje podataka o kupcima | **Banić**
F06    | Izrada članskih opcija  | Administrator ima mogućnosti izrade, ažuriranja i brisanja članskih opcija koje se koriste kod izrade članske iskaznice | **Banić**
F07    | Rezervacija ~~filmova~~ **lijekova**  | Korisnik ima mogućnost prijave u sustav, ako je prije toga izradio člansku iskaznicu. Korisnik ima mogućnost rezervirati ~~film~~ **lijek** online koji kasnije može fizički ~~posuditi~~ **preuzeti. Ako lijek nije dostupan, sustav će korisniku automatski poslati mail čim lijek postane dostupan (vidi F11)** | **Baukovac**
**OBRISATI F08**    | Produljenje iskaznice | Korisnik ima mogućnost produljiti ili izmjeniti opciju članarine online ako je prije toga napravio člansku iskaznicu | U dogovoru s mentorom
F09    | Nabava ~~filmova~~ **lijekova**  | Zaposlenici su zaduženi za izradu **narudžbenice, a potom i** primke na temelju otpremnice dobivene od dobavljača te se ona izrađuje prilikom zaprimanja novog ~~filma~~ **lijeka** kako bi podaci bili vidljivi u sustavu. Ako ~~film~~ **lijek** ne postoji u sustavu, ~~administrator~~ **zaposlenik** unosi podatke o njemu  | **Baukovac**
**F10** | **Izvješća** | **Izraditi izvješća s tabličnim i graf prikazima o kupcima (loyalty karticama), prometu, lijekovima i slično. Izvješća je potrebno spremiti u PDF i omogućiti ispis.** | **Arki**
**F11** | **Obavijest** | **Aplikacija automatski šalje e-mail podsjetnike klijentima o svim rezervacijama lijekova koji su stigli toga dana. Potrebno implementirati kao windows servis koji admin apoteke može upaliti ili ugasiti.** | **Banić**
**F12** | **Analiza** | **Sustav svako jutro automatski šalje mail sa popisom lijekova kojih će nestati na zalihama u sljedećih N dana (7 <= N <= 30, podesivo u sustavu). Izračun se temelji na projekciji buduće prodaje temeljem podataka o prodaji u prethodnih M dana (30 <= M <= 90, podesivo u sustavu)** | **Baukovac**
