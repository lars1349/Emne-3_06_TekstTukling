namespace Emne_3_06_TekstTukling_ny
{
    internal class Program
    {


        static void Main(string[] args)
        { 
    //   Oppgave: TekstTukling
    //     Lag et enkelt kommandobasert program med følgende meny: 
    //   1. Reverse Text   2. Change Word
    // Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord.
    // Ordet skal da enten snus eller endres med følgende funksjoner
    // 1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge.
    // For eksempel skal 'Terje' bli til 'ejreT.
    // 2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn.

            Console.WriteLine("Welcome!\nPlease select one of the two following (Press '1' or '2')\n" +
                              "1. Rotate input text\n" +
                              "2. Change all E's with A's");

            while (true)
            {
                string numbInput = Console.ReadLine();

                switch (numbInput)
                {
                    case "1":
                        Console.WriteLine("Type a word you wanna reverse.");
                        string reverseText = Console.ReadLine();

                        if (!string.IsNullOrEmpty(reverseText))
                        {
                            string reversedWord = new string(reverseText.Reverse().ToArray());
                            Console.WriteLine($"{reversedWord}");
                        }
                        else
                        {
                            Console.WriteLine("Please type a word.");
                        }
                        break;
                    
                    case "2":
                        Console.WriteLine("Type a word you want to change every 'E' with 'A'.");
                        string inputReplaceLetter = Console.ReadLine();

                        if (!string.IsNullOrEmpty(inputReplaceLetter))
                        {
                            string replacedLetters = new string(inputReplaceLetter.Replace('E', 'A').Replace('e', 'a').ToArray());
                            Console.WriteLine($"{replacedLetters}");
                        }
                        return;
                }
            }
        }
    }
}



