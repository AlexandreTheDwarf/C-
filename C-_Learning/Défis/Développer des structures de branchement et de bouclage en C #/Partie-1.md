## Projet de défi - Développer des structures de branchement et de bouclage en C #

### Exercice - Vérifier que petAge et petPhysicalDescription contiennent des informations valides : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/challenge-project-develop-branching-looping-structures-c-sharp/3-exercise-build-loop-verify-physical)

#### Ma réponse :
```
case "3":
            // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // Vérification de l'âge de l'animal
                    string age = ourAnimals[i, 2].Split(':')[1].Trim(); // Récupérer l'âge de l'animal
                    while (age == "?" || !int.TryParse(age, out _))
                    {
                        Console.WriteLine($"L'âge de l'animal avec l'ID {ourAnimals[i, 0].Split(':')[1].Trim()} est manquant ou invalide. Veuillez le mettre à jour.");
                        Console.Write("Nouvel âge : ");
                        age = Console.ReadLine();
                    }
                    ourAnimals[i, 2] = "Age: " + age;

                    // Vérification de la description physique de l'animal
                    string physicalDescription = ourAnimals[i, 4].Split(':')[1].Trim(); // Récupérer la description physique de l'animal
                    while (string.IsNullOrEmpty(physicalDescription) || physicalDescription.Length == 0)
                    {
                        Console.WriteLine($"La description physique de l'animal avec l'ID {ourAnimals[i, 0].Split(':')[1].Trim()} est manquante ou invalide. Veuillez la mettre à jour.");
                        Console.Write("Nouvelle description physique : ");
                        physicalDescription = Console.ReadLine();
                    }
                    ourAnimals[i, 4] = "Physical description: " + physicalDescription;
                }
            }
            Console.WriteLine("Vérification des âges et des descriptions physiques terminée.");
            Console.WriteLine("Appuyez sur une touche pour continuer.");
            Console.ReadLine();
            break;
```



