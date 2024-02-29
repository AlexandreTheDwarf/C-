# Mon code :

### Qu’est-ce que la mise en forme composite ?

```
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{0} {0} {0}!", first, second);
```

### Qu’est-ce que l’interpolation de chaîne ?

```
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
```

### Mise en forme de valeurs monétaires :

```
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
```

### Mise en forme des nombres :

```
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
```

### Mise en forme des pourcentages :

```
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
```

### Combinaison d’approches de mise en forme :

```
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);


decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
```

## Récapitulatif :

Voici les points les plus importants à retenir de cette unité concernant la mise en forme des chaînes :

- Vous pouvez utiliser la mise en forme composite ou l’interpolation de chaîne pour mettre en forme des chaînes.

- Avec la mise en forme composite, vous utilisez un modèle de chaîne contenant un ou plusieurs jetons de remplacement sous la forme {0}. Vous fournissez également une liste d’arguments qui sont mis en correspondance avec les jetons de remplacement selon leur ordre. La mise en forme composite fonctionne quand vous utilisez string.Format() ou Console.WriteLine().

- Avec l’interpolation de chaîne, vous utilisez un modèle de chaîne contenant les noms de variables qui doivent être remplacés, placés entre accolades. Utilisez la directive $ devant le modèle de chaîne pour indiquer que vous voulez que la chaîne soit interpolée.

- Mettez en forme les valeurs monétaires à l’aide d’un spécificateur :C.

- Mettez en forme les nombres à l’aide d’un spécificateur :N. Contrôlez la précision (nombre de valeurs après le séparateur décimal) en plaçant un nombre après le :N ; par exemple, {myNumber:N3}.

- Mettez en forme les pourcentages à l’aide du spécificateur de format :P.
La mise en forme des valeurs monétaires et des nombres dépend de la culture de l’utilisateur final, un code de cinq caractères qui comprend le pays/la région et la langue de l’utilisateur (conformément aux paramètres définis sur son ordinateur).