# Mon code :

## Afficher le numéro de facture à l’aide de l’interpolation de chaîne :

```
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
```

### Afficher les parts du produit avec une précision d’un millième de part (0,001) :

```
Console.WriteLine($"   Shares: {productShares:N3} Product");
```

### Afficher le sous-total que vous facturez au client au format monétaire :

```
Console.WriteLine($"     Sub Total: {subtotal:C}");
```

### Afficher la taxe prélevée sur la vente sous forme de pourcentage :

```
Console.WriteLine($"           Tax: {taxPercentage:P2}");
```

### Finaliser le reçu avec le montant total dû au format monétaire :

```
Console.WriteLine($"     Total Billed: {total:C}");
```