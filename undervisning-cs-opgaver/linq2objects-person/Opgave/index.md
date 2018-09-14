﻿# LINQ to Objects

Start med at skabe en tom konsol applikation, og tilføj via NuGet pakken MCronbergPersonRepository (søg efter ”cronberg”). Det vil tilføje mappen /Models/PersonNuGetPackage og nogle klasser der kan bruges til at levere data som vi kan lege med ved hjælp af LINQ. Bemærk at klasserne leverer tilfældige data – eksempelvis:

```csharp
var r = new PersonNuGetPackage.PersonRepositoryRandom();
var people = r.GetPeople(100);
foreach (var person in people)
    Console.WriteLine(person.Name);
```

Prøv det først – hent et antal (10 eksempelvis) personer og udskriv navnet.

Prøv herefter:

- Sorter og udskriv efter navn og udskriv igen
- Sorter og udskriv efter gender og så navn
- Filtre og udskriv således, at der kun vises personer hvor height < 170
- Filtre og udskriv således, at der kun vises personer hvor gender=  < 170, isHealthy = true
- Gruppér efter gender og udskriv hver gruppe (husk – der er tale om tilfældige navn/gender mv)
- Sorter og udskriv navn – men der skal kun returneres et anonymt objekt med navn og height	
- Grupper og sorter efter height således, at der skabes grupper fra 160-170, 170-180, 180-190, 190-200, 200-210. Den svær .. kig i løsningen og søg evt på nettet.
 
Prøv at bruge både LINQ og Lambda.

<!-- footerstart -->
> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)
<!-- footerslut -->