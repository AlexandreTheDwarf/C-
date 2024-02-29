## Effectuer une mise en forme de chaîne de base en C#

### Défi : Mettre en forme et afficher des instructions : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-basic-formatting/5-challenge)

#### Ma réponse :
```
string projectName = "ACME";
string englishMessage = "View English Output:";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"{englishMessage}: 
    C:\Exercice\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}: 
    C:\Exercice\{projectName}\ru-Ru\data.txt");
```

#### Solution Microsoft :
```
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
```

Je comprend que ma réponse est moins optimisé que celle de Microsoft, et surtout que je n'ai pas utilisé \n et \t pour faire des sauts de ligne et des tabulations. Je ne pouvais pas les utilisé à cause des chaines de caractères et j'ai donc trouvé une autre solution mais qui ne semble pas etre la bonne pratique. Je n'ai pas pensé a faire une variable avec la location qui surement a long terme est plus optimisé que de la mettre dans la chaine de caractère.