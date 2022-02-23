/*
A feladat boros pince hordóival kapcsolatos. Készítsen egy boros hordó (wine barrel) osztályt amelyben eltárolható a bor neve (szöveg) és a bor mennyisége a hordóban (egész szám). 
A boroshordó a benne lévő bor megnevezésének és a benne lévő bor mennyiségének a megadásával jöhet létre!
Boroshordó létrehozásakor a felhasználó negatív számot is megadhat a mennyiség paraméternek. Ilyenkor a boroshordó legyen üres!
A boros hordó osztályhoz biztosítson egy metódust, amely segítségével a gazda adott mennyiségű bort vehet ki a hordóból (take out wine). 
A gazda csak annyi bort vehet ki a hordóból amennyi abban benne van, vagy annál kevesebbet! Ha nem lehetséges adott mennyiségű bor kivétele, akkor semennyi nem kerül kivételre!
A hordóban lévő bor mennyiségének ellenőrzésére írnia kell egy metódus, amely kiírja a bor megnevezését és mennyiségét. A metódus neve legyen „ToConsole”. 
Pl. ha a bor neve neve „Egri leányka”, és a és a hordóban lévő bor mennyisége 100 liter, akkor a kiírást egy új sorral záruljon és a következő formátumba jelenjen meg: Egri leányka mennyisége a hordóban 100 liter.
Figyeljen oda, hogyha már elfogyott a hordóban a bor és ki akarnak venni belőle bort, akkor írja ki a képernyőre a ToConsole metódus a következő üzenetet: „A hordó üres!” Ellenőrzésként vegye fel Boros Béla olaszrizlinget tartalmazó hordóját, amelyben 60 liter bot van, és mutassa be, hogyan fogyott el a bor a hordóból! Egyszer próbáljon meg több bort kivenni a hordóból, mint amennyi abban van!
Dokumentálja az elkészült osztályt UML osztálydiagrammal!
*/

using System;

namespace _01_02_02_WineBarrel
{
   
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
