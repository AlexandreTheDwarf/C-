## Calculer la température en degrés Celsius en fonction de la température actuelle en degrés Fahrenheit

### A partir de cette ligne calculer la température en celcius

```
int fahrenheit = 94;
```

### Ma réponse :

```
int fahrenheit = 94;
double celsius = (fahrenheit - 32) * 5.0 / 9.0;
Console.WriteLine($"The temperature is {celsius} degrees Celsius.");
```

### Solution Microsoft :

```
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
```