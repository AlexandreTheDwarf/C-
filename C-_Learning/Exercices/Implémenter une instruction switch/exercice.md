# Exercice - Implémenter une instruction switch [link](https://learn.microsoft.com/fr-fr/training/modules/csharp-switch-case/2-exercise-switch-case)

## Mon code :

```
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
```