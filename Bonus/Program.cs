/*Nel progetto csharp-geometria creare le seguenti classi :
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi:
calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di 
altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di 
base e altezza (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.
Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e 
provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
—— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2 */

//--------------------- Parte 1 --------------------
using Bonus;
using System;

//Rettangolo hardcodato per debug

Rettangolo RettangoloEsercizio = new Rettangolo();
RettangoloEsercizio.AltezzaRettangolo = 10;
RettangoloEsercizio.BaseRettangolo = 20;
RettangoloEsercizio.Nome = "Parte 1";
RettangoloEsercizio.StampaRettangolo();   // Ho creato questo metodo nella parte 3, lo utilizzerò per stampare
                                          // in maniera piu ordinata tutti i rettangoli, da qui in avanti!
                                          // Il metodo richiama anche i metodi calcola area/perimetro

//--------------------- Parte 2 --------------------

Rettangolo RettangoloInput = new Rettangolo();
Console.WriteLine("Inserisci il nome del rettangolo");
RettangoloInput.Nome = (Console.ReadLine());


Console.WriteLine("Inserisci il valore \"Altezza\"");
RettangoloInput.AltezzaRettangolo = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il valore \"Base\"");
RettangoloInput.BaseRettangolo = float.Parse(Console.ReadLine());

while (RettangoloInput.AltezzaRettangolo == RettangoloInput.BaseRettangolo)
    {
    Console.WriteLine("Per costruire un rettangolo, Base ed Altezza devono essere diversi! \n Ritenta!");
    Console.WriteLine("Inserisci il valore \"Altezza\"");
    RettangoloInput.AltezzaRettangolo = float.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci il valore \"Base\"");
    RettangoloInput.BaseRettangolo = float.Parse(Console.ReadLine());
    }


RettangoloInput.StampaRettangolo();

//--------------------- Parte 3 --------------------

Rettangolo Rettangolo1 = new Rettangolo();
Rettangolo1.AltezzaRettangolo = 11;
Rettangolo1.BaseRettangolo = 30;
Rettangolo1.Nome = "Rettangolo1";
Rettangolo1.StampaRettangolo();

Rettangolo Rettangolo2 = new Rettangolo();
Rettangolo2.AltezzaRettangolo = 40;
Rettangolo2.BaseRettangolo = 50;
Rettangolo2.Nome = "Rettangolo2";
Rettangolo2.StampaRettangolo();

Rettangolo Rettangolo3 = new Rettangolo();
Rettangolo3.AltezzaRettangolo = 40;
Rettangolo3.BaseRettangolo = 50;
Rettangolo3.Nome = "Rettangolo3";
Rettangolo3.StampaRettangolo();

//--------------------- Parte 4 --------------------


// potrei unire Disegnarettangolo a Stamparettangolo in maniera da completare ancora di piu il metodo
// lascio cosi per permettere una piu semplice correzione dell' esercizio (per non macchiare parte 1/2/3 

// Ciao Emanuele!

Rettangolo1.DisegnaRettangolo();
