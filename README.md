# Isogramma

***Determina se una parola o una frase è un isogramma.***

***Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute.***
***Sono ammessi spazi e segni di punteggiatura ripetuti.***
***Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca.***

***Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.***

```c#

using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {


     var alfabeto = new int [26];



        foreach(var Letter in word.ToLower())
        {

            
            if (Char.IsLetter(Letter))
            {
                alfabeto [Letter - 'a']++;
                if (alfabeto[Letter - 'a'] > 1)
                    return false;
            }
        }
        return true;
    }

}

```

**Questo codice C# definisce una classe statica chiamata "Isogramma" con un metodo statico chiamato "Verifica". Il metodo prende in input una stringa e restituisce un valore booleano.***

***Il metodo "Verifica" controlla se la stringa passata come parametro rappresenta una parola isogramma, ovvero una parola in cui ogni lettera appare una sola volta.***

***Per fare ciò, viene creato un array di interi "alfabeto" di dimensione 26, che tiene traccia di quante volte ogni lettera dell'alfabeto appare nella stringa.***

***Viene quindi iterata ogni lettera della stringa "word" utilizzando un ciclo "foreach". Per ogni lettera, viene verificato se è una lettera dell'alfabeto utilizzando la funzione "Char.IsLetter".***

***Se la lettera è una lettera dell'alfabeto, viene incrementato il contatore corrispondente nell'array "alfabeto". Se il contatore per quella lettera diventa maggiore di 1, significa che la parola non è un isogramma, quindi viene restituito "false".***

**Se tutte le lettere nella stringa sono state contate una sola volta, la funzione restituisce "true", indicando che la parola è un isogramma.***
