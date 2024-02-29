## Effectuer une activité de défi impliquant l’utilisation des instructions d’itération do et while

### Défi d’affrontement dans un jeu de rôle : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-do-while/3-challenge)

#### Ma réponse :
```
int HpHero = 10;

Random rnd = new Random(); // Utilisé pour générer des valeurs aléatoires pour les attaques
        
Console.WriteLine("Le combat commence!");
Console.WriteLine("Appuyez sur une touche pour commencer...");

Console.Read(); // Attend une entrée de l'utilisateur avant de commencer le combat
        
// Création de la liste de monstres
List<string> monsters = new List<string> { "Gobelin", "Orc", "Dragon", "Lapin de Caerbannog" };

// Sélection aléatoire du monstre
string selectedMonster = monsters[rnd.Next(monsters.Count)];
        
// Si le monstre est le Lapin de Caerbannog, le chevalier meurt instantanément
if (selectedMonster == "Lapin de Caerbannog")
    {
        Console.WriteLine("Le Lapin de Caerbannog apparaît !");
        Console.WriteLine("Le Lapin de Caerbannog attaque le héros...");
        Console.WriteLine("Le chevalier est immédiatement tué par le Lapin de Caerbannog !");
        Console.WriteLine("Fin du combat!");

        return;
    }

else
    {
        Console.WriteLine("Un " + selectedMonster + " apparaît !");
    }

int HpMonster = 10; // Points de vie du monstre
       
// Boucle while pour continuer le jeu tant que les deux participants ont des points de vie
while (HpHero > 0 && HpMonster > 0)
    {
        // Tour du héros
        int heroAttack = rnd.Next(1, 11); // Génère une valeur aléatoire entre 1 et 10 pour l'attaque du héros
        Console.WriteLine("Le héros attaque le " + selectedMonster + " avec une force de " + heroAttack);
        int damageToMonster = Math.Min(heroAttack, HpMonster); // Calculer les dégâts infligés au monstre
        HpMonster -= damageToMonster; // Réduit les points de vie du monstre en fonction des dégâts
            
        // Afficher les dégâts infligés et les points de vie restants du monstre
        Console.WriteLine("Le " + selectedMonster + " a perdu " + damageToMonster + " points de vie.");
        Console.WriteLine("Points de vie restants du " + selectedMonster + ": " + HpMonster);
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.Read(); // Attend une entrée de l'utilisateur avant de continuer le combat
            
        // Vérifie si le monstre est vaincu
        if (HpMonster <= 0)
            {
                Console.WriteLine("Le héros a vaincu le " + selectedMonster + "!");
                break; // Sort de la boucle si le monstre est vaincu
            }
            
        // Tour du monstre
        int monsterAttack = rnd.Next(1, 11); // Génère une valeur aléatoire entre 1 et 10 pour l'attaque du monstre
        Console.WriteLine("Le " + selectedMonster + " attaque le héros avec une force de " + monsterAttack);
        int damageToHero = Math.Min(monsterAttack, HpHero); // Calculer les dégâts infligés au héros
        HpHero -= damageToHero; // Réduit les points de vie du héros en fonction des dégâts
            
        // Afficher les dégâts infligés et les points de vie restants du héros
        Console.WriteLine("Le héros a perdu " + damageToHero + " points de vie.");
        Console.WriteLine("Points de vie restants du héros: " + HpHero);
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.Read(); // Attend une entrée de l'utilisateur avant de continuer le combat
            
        // Vérifie si le héros est vaincu
        if (HpHero <= 0)
        {
            Console.WriteLine("Le " + selectedMonster + " a vaincu le héros!");
            break; // Sort de la boucle si le héros est vaincu
        }
            
        // Laisser une ligne vide pour la lisibilité entre les tours
        Console.WriteLine();
    }

Console.WriteLine("Fin du combat!");
```

#### Solution Microsoft :
```
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
```


