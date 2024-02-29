# Mon code : [link](https://learn.microsoft.com/fr-fr/training/modules/csharp-format-strings/4-exercise-string-methods-padding)

## Mise en forme de chaînes en les faisant précéder ou suivre d’un espace blanc :

```
string input = "Pad this";
 Console.WriteLine(input.PadLeft(20));
```
## Qu’est-ce qu’une méthode surchargée ? 

```
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12, '~'));
 Console.WriteLine(input.PadRight(12, '-'));
```

## Utilisation de chaînes remplies :

### Ajouter l’ID de paiement (Payment ID) à la sortie :

```
string paymentId = "769C";

 var formattedLine = paymentId.PadRight(6);

 Console.WriteLine(formattedLine);
```

### Ajouter le nom du bénéficiaire à la sortie :

```
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 Console.WriteLine(formattedLine);
```

### Ajouter le montant du paiement à la sortie :

```
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine);
```

### Ajouter une ligne de nombres au-dessus de la sortie pour vérifier plus facilement le résultat

```
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);
```