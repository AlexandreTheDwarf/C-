## Projet de défi - Développer des structures de branchement et de bouclage en C #

### Exercice - S’assurer que les surnoms d’animaux et les descriptions de personnalité sont complets : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/challenge-project-develop-branching-looping-structures-c-sharp/4-exercise-build-loop-verify-personality)

#### Ma réponse :
```
case "4":
// Ensure animal nicknames and personality descriptions are complete
    for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // Vérification du surnom
                    animalNickname = ourAnimals[i, 5].Split(':')[1].Trim(); // Récupérer le surnom de l'animal
                    while (string.IsNullOrEmpty(animalNickname) || animalNickname.Length == 0)
                    {
                        Console.WriteLine($"Le surnom de l'animal avec l'ID {ourAnimals[i, 0].Split(':')[1].Trim()} est manquant ou invalide. Veuillez le mettre à jour.");
                        Console.Write("Nouveaux surnom : ");
                        animalNickname = Console.ReadLine();
                    }
                    ourAnimals[i, 5] = $"Nickname: {animalNickname}"; // Mettre à jour le surnom dans le tableau

                    // Vérification de la description personnel de l'animal
                    animalPersonalityDescription = ourAnimals[i, 4].Split(':')[1].Trim(); // Récupérer la description du caractère de l'animal
                    while (string.IsNullOrEmpty(animalPersonalityDescription) || animalPersonalityDescription.Length == 0)
                    {
                        Console.WriteLine($"Le caractère de l'animal avec l'ID {ourAnimals[i, 0].Split(':')[1].Trim()} est manquant. Veuillez le mettre à jour.");
                        Console.Write("Nouveau caractère : ");
                        animalPersonalityDescription = Console.ReadLine();
                    }
                    ourAnimals[i, 4] = $"Personality: {animalPersonalityDescription}"; // Mettre à jour la description du caractère dans le tableau
                }
            }
            Console.WriteLine("Vérification du pseudonyme et du caractère terminée.");
            Console.WriteLine("Appuyez sur une touche pour continuer.");
            Console.ReadLine();
            break;                    
```
