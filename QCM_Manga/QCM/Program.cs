using System.Formats.Asn1;

int score = 0;

Console.WriteLine("Bienvenue dans ce petit QCM Manga");

// Question 1
bool isValidAnswer1 = false;
while (!isValidAnswer1)
{
    Console.WriteLine("Quel est le nom du slime dans Moi quand je me réincarne en slime ?");
    Console.WriteLine("1. Naruto");
    Console.WriteLine("2. Limule");
    Console.WriteLine("3. Benimaru");

    int answer1;
    if (int.TryParse(Console.ReadLine(), out answer1) && (answer1 >= 1 && answer1 <= 3))
    {
        isValidAnswer1 = true;

        if (answer1 == 2)
        {
            score += 1;
        }
    }
    else
    {
        Console.WriteLine("Veuillez entrer une réponse valide (1, 2, ou 3).");
    }
}

// Question 2
bool isValidAnswer2 = false;
while (!isValidAnswer2)
{
    Console.WriteLine("Quelle est la classe principale du personnage principal de Overlord ?");
    Console.WriteLine("1. Voleur");
    Console.WriteLine("2. Paladin");
    Console.WriteLine("3. Mage");

    int answer2;
    if (int.TryParse(Console.ReadLine(), out answer2) && (answer2 >= 1 && answer2 <= 3))
    {
        isValidAnswer2 = true;

        if (answer2 == 3)
        {
            score += 1;
        }
    }
    else
    {
        Console.WriteLine("Veuillez entrer une réponse valide (1, 2, ou 3).");
    }
}

Console.WriteLine($"Ton score est {score}");

