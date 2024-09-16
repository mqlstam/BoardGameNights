# ATIx

# avanshogeschool

# SERVERSIDE WEB DEVELOPMENT

# INDIVIDUEEL

# OPDRACHT BESCHRIJVING BORDSPELLEN

# IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 1 van 15
---
# INHOUDSOPGAVE

# Inleiding

.............................................................................................................................. 3

# Doel

.................................................................................................................................... 3

# Casus

.................................................................................................................................. 3

# US_01

Als persoon wil ik kunnen zien welke bordspellenavonden er zijn, aan welke ik deelneem en welke ik organiseer, zodat ik makkelijk naar deze kan navigeren..............4

# US_02

Als organisator wil ik een bordspellenavond kunnen organiseren, zodat personen zich op kunnen geven voor deze avond...........................................................................5

# US_03

Als organisator wil ik een bordspellenavond alleen voor volwassenen beschikbaar stellen, zodat minderjarigen niet mee kunnen doen aan bordspellenavonden met spellen voor volwassenen........................................................5

# US_04

Als speler wil ik me in kunnen schrijven voor een spelavond, zodat ik deel kan nemen aan een avond..................................................................................................... 5

# US_05

Als speler wil ik weten wat voor spellen er worden gespeeld op een bordspellenavond, zodat ik weet of ik de spellen leuk vind.............................................6

# US_06

Als speler wil ik weten wat voor eten en drinken er is zodat ik altijd iets kan eten/drinken wat bij mijn wensen past............................................................................6

# US_07

Als organisator wil ik de spelers kunnen vragen om zelf snacks mee kunnen nemen (potluck), zodat ik geen snacks hoef in te kopen en er veel verschillende soorten snacks zijn.............................................................................6

# US_08

Als speler wil ik weten hoe vaak een organisator een spellenavond heeft georganiseerd en hoe goed deze zijn gegaan, zodat ik weet of het een goed idee is om naar deze avond heen te gaan en of de spellenavond bij mij past................................................................................................................................ 7

# US_09

Als organisator wil ik weten of mensen bij andere bordspellenavonden niet gekomen zijn terwijl ze zich wel hadden aangemeld, zodat ik daar in mijn inkopen rekening mee kan houden...........................................................................8

# Opdracht

............................................................................................................................. 9

# Oplevering

........................................................................................................................ 13

# Bibliografie

....................................................................................................................... 14

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 2 van 15
---
# INLEIDING

Aan het begin van periode IVT2.1 heb je kennisgemaakt met het ontwikkelen van een webapplicatie met behulp van het ASP.net MVC Core framework, en heb je ook een aantal vaardigheden geleerd op het gebied van UX-design. In Software ontwerp & -architectuur 2 komt aantal applicatie-architecturen aan bod, zoals de clean (onion) architecture (Smith, 2017). In deze architectuurstijl staat de application core, het domeinmodel met bijbehorende services, centraal, (Figuur 1). Ook het ontwikkelen van een RESTful web API komt daar aan bod. De opdracht bij het onderdeel ServerSide Web Development Individueel (EIIN-SSWPI) integreert de genoemde vakken.

# Figuur 1

Onion architecture

In EIIN-SSWPI ontwikkel je een webapplicatie en een webservice en maakt daarbij gebruik van een software-ontwikkelstraat met automatische tests en deployment.

# DOEL

Het doel van deze opdracht is het ontwikkelen van een webapplicatie in ASP.net MVC Core waarbij je een UX-design maakt, een goede applicatie-architectuur toepast en waarbij je een ontwikkelstraat gebruikt, die automatisch de unit tests uitvoert en deployed (inclusief de database). Tijdens het afrondend assessment demonstreer je je uitwerking en licht je gemaakte keuzes toe.

# CASUS

Immigranten die naar Nederland komen hebben vaak moeite om de Nederlandse taal te leren en om te integreren in onze samenleving. Deze twee problemen hebben veel met elkaar te maken: als je geen Nederlands spreekt voel je je al snel buitengesloten als je bijvoorbeeld iets gaat drinken bij een café.

Om deze groep te helpen met het leren van Nederlands wordt een bordspellenavond georganiseerd door een taalschool in samenwerking met een buurtvereniging. Het doel van de bordspellenavond is om door het spelen van spellen een gezellige avond te hebben, vrienden te maken en spelenderwijs Nederlands te leren.

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 3 van 15
---
# IVT2.1 ServerSide Web Development Individueel – Opdracht

De taalschool en de buurtvereniging hebben de studenten van Avans gevraagd om een web-gebaseerd softwaresysteem te maken om deze avonden te organiseren.
---
# Wie zijn de actoren?

In het systeem bestaat natuurlijk de gebruiker. Een persoon kan zowel een bordspellenavond organiseren als zich aansluiten bij een al georganiseerde bordspellenavond in de rol van speler. Een persoon kan dus organisator of speler zijn.

Van iedere persoon is de naam, emailadres, geslacht en woonadres bekend (straat, huisnummer en stad).

Van een persoon is verder de geboortedatum en het geslacht (M, V, X) bekend. De geboortedatum mag niet in de toekomst liggen en de leeftijd bij aanmelden voor een account is minimaal 16 jaar.

Als een persoon een bordspellenavond wil organiseren moet deze minimaal 18 jaar oud zijn.

Een bordspellenavond is op een bepaalde datum en tijd ingepland. Van zo’n bordspellenavond moet ieder geval de volgende informatie bijgehouden worden:

- De persoon die de avond organiseert
- Het adres van de avond
- De spelers die meedoen
- Het maximaal aantal spelers
- De datum en tijd
- Eventueel reviews: (zie US_9)
- De gespeelde bordspellen (zie US_5)
- Het eten wat beschikbaar is (zie US_6 en evt. US_08)

Een bordspellenavond is natuurlijk niets zonder een bordspel. Van de bordspellen moet de volgende informatie opgeslagen worden:

- De naam
- De beschrijving
- Het genre (enumeratie)
- Of deze 18+ is
- Foto
- Soort spel (b.v. kaartspel, bordspel, …. Deze staan vast dus kan als enumeratie)

# Wat zijn de user stories?

Userstory 1 tot en met 6 zijn verplicht. Naast deze user story’s kies je 1 extra userstory van 7, 8 of 9. In totaal moeten dus minimaal 7 userstories geïmplementeerd worden.

# US_01 ALS PERSOON WIL IK KUNNEN ZIEN WELKE BORDSPELLENAVONDEN ER ZIJN, AAN WELKE IK DEELNEEM EN WELKE IK ORGANISEER, ZODAT IK MAKKELIJK NAAR DEZE KAN NAVIGEREN.

Storypoints: 3

# Toelichting:

Personen moeten makkelijk bij hun bordspellenavonden kunnen komen. Maak deze daarom toegankelijk voor de personen. Hoe je dit inricht is aan jou.

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 5 van 15
---
# Acceptatiecriteria:

- Er zijn drie pagina’s. Een waarin alle bordspellenavonden te zien zijn, één waarin de door de persoon georganiseerde bordspellenavonden te zien zijn, één waarin de bordspellenavonden waaraan de persoon deelneemt te zien zijn.

# US_02 ALS ORGANISATOR WIL IK EEN BORDSPELLENAVOND KUNNEN ORGANISEREN, ZODAT PERSONEN ZICH OP KUNNEN GEVEN VOOR DEZE AVOND.

Storypoints: 2

# Toelichting:

Als organisator moet ik bordspellenavonden kunnen organiseren, omdat anders het initiatief geen zin heeft.

# Acceptatiecriteria:

- Een organisator moet een nieuwe bordspellenavond toe kunnen voegen, kunnen wijzigen en verwijderen.
- Wijzigen of verwijderen van een bordspellenavond mag alleen als er nog geen spelers zich ingeschreven hebben voor deze avond.

# US_03 ALS ORGANISATOR WIL IK EEN BORDSPELLENAVOND ALLEEN VOOR VOLWASSENEN BESCHIKBAAR STELLEN, ZODAT MINDERJARIGEN NIET MEE KUNNEN DOEN AAN BORDSPELLENAVONDEN MET SPELLEN VOOR VOLWASSENEN.

Storypoints: 1

# Toelichting:

Sommige bordspellen zijn voor volwassenen (denk aan Cards Against Humanity) en daar wil je dus geen kinderen bij hebben. Een organisator moet dus ervoor kunnen kiezen om een bordspellenavond alleen voor volwassenen te laten zijn.

# Acceptatiecriteria:

- Een bordspel en bordspellenavond hebben een eigenschap dat deze 18+ is of niet.
- Als een bordspel 18+ is, is een bordspellenavond met dat spel ook automatisch 18+
- Iemand van onder de 18 kan niet meedoen aan een 18+ bordspellenavond.

# US_04 ALS SPELER WIL IK ME IN KUNNEN SCHRIJVEN VOOR EEN SPELAVOND, ZODAT IK DEEL KAN NEMEN AAN EEN AVOND.

Storypoints: 1

# Toelichting:

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 6 van 15
---
# ATIx

Als speler moet ik me vooraf opgeven voor een avond, zodat ik ook deel kan nemen aan deze avonden en zo een leuke avond kan hebben.

# Acceptatiecriteria:

- Als speler moet ik me aan kunnen melden voor een spelavond, mits deze niet vol is (aantal aanmeldingen == max aantal spelers) en mits deze geschikt is voor mijn leeftijd (18+ avonden).
- Als speler kan ik me maximaal voor 1 spelavond per dag aanmelden. Het tijdstip van de spelavond is hierbij niet belangrijk.

# US_05 ALS SPELER WIL IK WETEN WAT VOOR SPELLEN ER WORDEN GESPEELD OP EEN BORDSPELLENAVOND, ZODAT IK WEET OF IK DE SPELLEN LEUK VIND

Storypoints: 3

# Toelichting:

Er zijn veel soorten bordspellen. Een speler moet dus kunnen zien wat voor spellen er worden gespeeld op een bordspellenavond en moet makkelijk kunnen zien of hij/zij deze leuk vindt of niet.

# Acceptatiecriteria:

- In de eigenschappen van een bordspellenavond zijn de bordspellen zichtbaar.
- In de eigenschappen van een bordspel zijn zaken zoals de naam, genre en of het spel 18+ is etc. duidelijk en aantrekkelijk weergegeven.

# US_06 ALS SPELER WIL IK WETEN WAT VOOR ETEN EN DRINKEN ER IS ZODAT IK ALTIJD IETS KAN ETEN/DRINKEN WAT BIJ MIJN WENSEN PAST.

Storypoints: 2

# Toelichting:

Bij een gezellige avond hoort natuurlijk snacks en wat te drinken. Mensen hebben alleen hele verschillende wensen. Een speler moet dus snel kunnen zien of het eten en drinken aansluit op hun dieet en/of allergieën.

# Acceptatiecriteria:

- Bij een bordspellenavond moet in ieder geval staan of er eten en drinken is voor:
- Mensen met een lactose of notenallergie
- Vegetariërs
- Mensen die geen alcohol mogen/willen drinken
- Als een persoon zich aanmeldt en zijn/haar dieetwensen en/of allergieën sluiten niet aan op de bordspellenavond, dan moet hiervoor een melding komen.
- Als een nieuwe persoon aangemaakt wordt, moet deze aan kunnen geven welke dieetwensen en/of allergieën deze heeft.

# US_07 ALS ORGANISATOR WIL IK DE SPELERS KUNNEN VRAGEN OM ZELF SNACKS MEE KUNNEN NEMEN (POTLUCK), ZODAT IK
---
# ATIx

# GEEN SNACKS HOEF IN TE KOPEN EN ER VEEL VERSCHILLENDE SOORTEN SNACKS ZIJN.

# Storypoints: 2

# Toelichting:

Bij een bordspellenavond kan aangegeven zijn dat iedereen wat snacks mee moet nemen. In dit geval moeten mensen kunnen invullen en aan welke eetwensen dit voldoet (zie US_03).

# Acceptatiecriteria:

- Gebruikers moeten bij óf na het aanmelden voor een bordspellenavond een formulier in vullen over het eten wat ze meenemen.
- Gebruikers moeten minimaal 1 ding meenemen.
- Na het invullen van het formulier moet het eten op de bordspellenavondpagina komen te staan (hier hoeft niet bij te staan wie het meeneemt).

# US_08 ALS SPELER WIL IK WETEN HOE VAAK EEN ORGANISATOR EEN SPELLENAVOND HEEFT GEORGANISEERD EN HOE GOED DEZE ZIJN GEGAAN, ZODAT IK WEET OF HET EEN GOED IDEE IS OM NAAR DEZE AVOND HEEN TE GAAN EN OF DE SPELLENAVOND BIJ MIJ PAST

# Storypoints: 2

# Toelichting:

Sommige mensen zijn beter in het organiseren van spellenavonden dan anderen. Het is ook fijn om te weten hoe iemand is voordat je een avond bij hen doorbrengt.

# Acceptatiecriteria:

- In deze review zit het volgende:
- Een score van 1 tot 5
- Een reviewtekst
- Boven de review staat de naam van de gebruiker die het ingevuld heeft.
- Bij de organisator is een gemiddelde te zien van alle reviews (dus alle reviews van de bordspellenavonden die deze organisator georganiseerd heeft).

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 8 van 15
---
# ATIx

# US_9

# ALS ORGANISATOR WIL IK WETEN OF MENSEN BIJ ANDERE BORDSPELLENAVONDEN NIET GEKOMEN ZIJN TERWIJL ZE ZICH WEL HADDEN AANGEMELD, ZODAT IK DAAR IN MIJN INKOPEN REKENING MEE KAN HOUDEN

Storypoints: 2

# Toelichting:

Dat mensen zich ergens voor aanmelden hoeft niet altijd te betekenen dat ze ook echt komen. Daarom willen organisatoren weten hoe vaak iemand niet is gekomen (een no-show). Na een bordspellenavond moet een organisator dit aan kunnen geven. Qua code lijkt dit op een review.

# Acceptatiecriteria:

- In een bordspellenavond moet een organisator bij elk lid aan kunnen geven of deze wel of niet is gekomen.
- In een bordspellenavond moet een organisator per speler kunnen zien hoeveel shows en no-shows deze speler in totaal heeft.

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 9 van 15
---
# ATIx

# OPDRACHT

De functionele requirements en business rules die van toepassing zijn heb je kunnen lezen in de vorige paragraaf. Wat de niet-functionele eisen betreft leggen we de focus op schaalbaarheid, onderhoudbaarheid en testbaarheid (zie ook Softwareontwerp & -architectuur). Een grove, conceptuele opzet voor de applicaties vind je in Figuur 2.

# Figuur 2 Conceptuele opzet

|MaaltijdreserveringsAvans Systeem|MaaltijdreserveringsAvans Systeem|
|---|
|Node|Persoon|
|Avans Spel|WebService|
|Organisator|Speler|
|Azure SQL Server|Spel DB|
| |Identity DB|

De Avans Spel Systeem is een ASP.NET MVC Core applicatie die voor gegevens over de spellen en avonden een SQL Server database gebruikt (In Azure heet deze Azure SQL Database). De inloggegevens worden in verband met veiligheid verplicht in een aparte database opgeslagen en worden beheerd door Identity Framework.

Door een ander team zal een mobiele applicatie worden geschreven, waarbij spelers alleen de lijst met avonden en spellen kunnen zien en zich aan kunnen melden voor een avond. Ons systeem biedt hiervoor een RESTful Web API (op RMM level 2) (aanmelden voor een specifieke avond) en een GraphQL endpoint (ophalen lijst met avonden en spelen) aan.

Deze webservice gaan we testen met Postman. (Tip: maak voor jezelf voor deze onderdelen ook 2 losse user story’s aan). Voor user accountmanagement en bijbehorende authenticatie en autorisatie gebruik je het Identity framework.

# IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 10 van 15
---
# Ontwerp

De beschrijving van het bordspellenavondsysteem is vrij generiek. Je geeft zelf de opdracht meer kleur door een thema te kiezen, door je bijvoorbeeld te richten op jonge mensen, expats, ouderen, een specifieke immigrantengroep, enz. Je houdt daarbij expliciet rekening met betrekking tot het UX-design. Je stuurt hiermee ook welke persona je van toepassing vindt en welke maatregelen je treft om een gebruiksvriendelijke userinterface te maken. De uitwerking van het UX-design neem je op in het portfolio dat voor dat vak is voorgeschreven.

Je maakt ook een aantal (UML-)diagrammen:

- Package- en klassendiagram voor toepassing van clean (onion) architectuur.
- Componentdiagram voor het gehele systeem.
- Deploymentdiagram voor het gehele systeem.
- In de toekomst willen we de webapplicatie gebruik laten maken van de webservice, zodat de webapplicatie niet meer direct toegang tot de database nodig heeft. Maak hiervoor een aangepast ontwerp waarbij je deze nieuwe situatie modelleert. Maak hierbij zelf een keuze welke diagramtypes hierbij het beste aansluiten.

De diagrammen heb je zelf met de hand gemaakt en zijn dus niet gegenereerd vanuit de code door bijvoorbeeld Visual Studio.

Het ontwerp en overige documentatie neem je op in een verslag. Zorg ervoor dat dit professioneel vormgegeven is. Neem b.v. een inleiding, samenvatting en beschrijvende tekst op, NIET alleen de diagrammen.

De Avans Spelavonden WebService biedt zijn functionaliteit aan via een correcte RESTful Web API die voldoet aan Richardson Maturity Model level (RMM) 2 en een los GraphQL-endpoint. De RMM2 variant voldoet aan de volgende criteria voor RESTful architectuur constraints (zie ook studiemateriaal SO&A 2):

- Client/server
- Stateless communication
- Resources
- Resources with multiple representations
- Standard operations

Het ontwerp voor de endpoints bestaat uit een schema met het gedrag voor de CRUD-operaties op de resources in termen van HTTPS verbs aangevuld met query’s voor GraphQL. Als een methode volgens de casus niet geïmplementeerd kan worden, dan moet een vooraf gedefinieerde foutmelding terug worden gegeven. Het gedrag wordt ondersteund voor zowel de verzameling resources als individuele resources. Je past de richtlijnen volgens Brian Mulloy van Apigee (Mulloy, 2012) toe op de Web API’s, daar waar het basisschema niet voldoende is. Je documenteert je Web API’s, dus de RMM level 2 en GraphQL, beide met behulp van Swagger.

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 11 van 15
---
# ATIx

# Code

Je programmeert je ontwerp in ASP.NET MVC Core 8 en C#. De code is netjes: volgens coding guidelines1, geen uitgecommentarieerde codeblokken, netjes uitgelijnd, geen warnings tijdens build, etc. Gebruik eventueel de editorconfig-feature op je hierbij te helpen.

Ook mogen er geen ongebruikte codebestanden of projecten meer in de solution aanwezig zijn. De naamgeving van de solution, de projecten en de bestanden moet relevant zijn (m.a.w. geen ‘Project1’, ‘Class1.cs’, etc). Hetzelfde geldt voor de naamgeving van code constructies (variabelen, classes, enums, etc).

Is de oplevering te rommelig (voldoet niet aan bovenstaande) resulteert dit in een NV!

Je past de volgende concepten toe:

1. Dependency injection d.m.v. een dependency injection container.
2. Domein validaties bevinden zich in het domein model.
3. Handelingen/ validaties over meerdere entiteiten gebeuren in een domein services project.
4. Persistentie in de database d.m.v. entity framework code first en migrations.
5. Relaties tussen modellen d.m.v. navigational properties.
6. Het gebruik maken van repositories op basis van interfaces zodat we eenvoudig de manier van dataopslag kunnen wijzigen.
7. Het kunnen maken van validatieregels op de velden van de models.
8. Het gebruik van strongly typed views.
9. Het gebruik van Microsoft Identity voor authenticatie en autorisatie voor zowel de webapplicatie als de webservice.
10. Toepassen van Lambda expressies om selecties te maken op datasets.

# Testen

Voor de business rules van het domein implementeer je unit testen. Je test dus geen standaard get-ers en set-ers van klassen waarbij ‘gewoon’ waardes direct worden teruggegeven of opgeslagen. Je past ook mocking toe (b.v. voor de repositories). De business rules staan vermeld in de acceptatiecriteria bij de user story’s. De tests omvatten de happy flow en een aantal foute scenario’s.

Tip: werk de unit testen per user story uit. Zo voorkom je dat je aan het eind van de opdracht tijd tekort komt om nog alle unit testen te schrijven.

Maak gebruik van versiebeheer (git) om het ontwikkelen makkelijker te maken (eventueel met feature branches).

De endpoints van de Avans Spelavonden webservice worden getest met end-to-end tests met behulp van een aantal collecties in Postman.

# Overig

Je werkt met CI/CD (continous integration/ continuous deployment) waarbij je gebruik maakt van een development pipeline (ontwikkelstraat) die automatisch een build start wanneer je wijzigingen levert (‘pusht’), daarna ook automatisch de unit testen uitvoert en vervolgens de webapps deployed, inclusief de twee databases.

1 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions

IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 12 van 15
---
# ATIx

Wijzigingen in entiteiten (modellen) moeten dus ook in de CD pipeline via migraties doorgevoerd worden op de Azure database. De gerealiseerde userinterface is consistent met het UX-design waarbij je de design principes uit UX-design 1 toepast. Ook als je UX Design 1 niet hoeft te doen, dan zorg je nog voor een gebruikersvriendelijke user interface. Als je aan het vak UX-design 1 deelneemt, kijk dan in het materiaal van dat vak op BrightSpace voor meer informatie.

# IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 13 van 15
---
# OPLEVERING

Voor alle studenten gelden de volgende bepalingen. Herkansers van vorige jaren moeten ook de complete opdracht uitwerken.

# Wat lever je in?

Lever de opdracht in via de Brightspace inleverlink; daar staat ook de deadline voor inleveren vermeld.

# De ingeleverde opdracht dient te bevatten:

- Opleveringsdocument met (UML-)diagrammen en verdere onderbouwing. Dit moet een net, professioneel vormgegeven document zijn.
- Gehele Visual Studio solution met alle projecten, zonder obj-files, binaries en packages folders als gecomprimeerd zip bestand. Gebruik de functie ‘Clean Solution’ uit het menu en verwijder eventueel de packages folder!
- (Is je solution zip tientallen of honderden MB’s groot kan dat uitsluiting van het assessment opleveren)
- Er is gebruik gemaakt van ASP.NET Core 8
- Nullable reference types zijn actief
- (dit is de default dus hoef je niets voor te doen)
- Er is een consistentie coding conventie gebruikt
- Er zijn geen warnings of errors
- Alleen NuGet vulnerability warnings mogen onderdrukt worden maar mogen niet zichtbaar zijn tijdens de build
- Er zijn GEEN lege bestanden, klasses uit de VS template of ongebruikte codebestanden aanwezig
- (b.v. class1.cs)
- Er zijn GEEN blokken code ‘commented out’ of niet in gebruik
- Correct versiebeheer (git met stash en branches) maakt het onnodig om blokken code tijdelijk te uit te ‘commenten’
- De solution ingericht volgens Onion Architecture met aparte projecten voor het domein, infra, API, webapp, etc
- Er worden GEEN EF migraties doorgevoerd in de programma code (seeden mag wel natuurlijk)
- Het domein model bevat entiteiten opgebouwd uit logische datatypes, hebben relaties met elkaar en er is minimaal een veel-op-veel relatie aanwezig
- URL van de gedeployde applicatie op Azure zodat de applicatie bezocht kan worden.
- URL van de devops omgeving (En de docent moet hier toegang toe hebben).
- Een account (gebruikersnaam én wachtwoord) waarmee de docent kan inloggen op jouw webapplicatie in Azure. Dit account moet voldoende rechten hebben om alle activiteiten uit te kunnen voeren.

# IVT2.1 ServerSide Web Development Individueel – Opdracht

Pagina 14 van 15
---
# IVT2.1 ServerSide Web Development Individueel – Opdracht

# ATIx

- Binnen de gedeployde applicatie moeten een aantal gebruikers aanwezig zijn (organisator en een aantal spelers). (tip: gebruik seeders)
- Swagger API-documentatie
- Postman collectie welke alle endpoints test. De collectie moet direct uit te voeren zijn zonder knippen en plakken van tokens; maak dus gebruik van de functionaliteit van Postman om dit mogelijk te maken.
- Video met een schermopname om aan te tonen dat alle functionaliteit van UC 1 tot en met 6 en een eigen te kiezen user story 7 t/m 9 in de applicatie (webapp + API) is opgenomen. Laat per user story zien dat je voldoet aan de acceptatiecriteria die per user story staan vermeld. De demonstratie moet de gedeployde webapp gebruiken, NIET de development versie op ‘localhost’!

Bovenstaande producten ingepakt in 1 zipfile met de volgende naam:

- &lt;klas&gt; - &lt;voornaam + achternaam&gt; - IVT2-1-SpelavondenApp.zip

Ontbreekt één van bovenstaande punten kun je NIET op assessment en zul je een herkansing moeten doen. Loop dus voor je het inlevert bovenstaande punten na!

# BIBLIOGRAFIE

- Mulloy, B. (2012). Web API Design. unknown: Apigee. Opgehaald van https://pages.apigee.com/rs/apigee/images/api-design-ebook-2012-03.pdf
- Smith, S. (2017). Architecting Modern Web Applications with ASP.NET Core and Azure. Redmond, Washington: Microsoft Corporation.

Pagina 15 van 15