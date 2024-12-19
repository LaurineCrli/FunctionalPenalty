# Projet : Simulation de tirs au but en programmation fonctionnelle

Ce projet propose une simulation d'une séance de tirs au but dans un match de football, avec une approche fonctionnelle en C#.
L'objectif est de respecter les principes de la programmation fonctionnelle, tels que l'immuabilité, les fonctions pures, et la gestion des erreurs sans exceptions.

## Fonctionnalités principales

- **Simulation de tirs au but** : Chaque tir est simulé aléatoirement (but ou échec).
- **Gestion de l'état immuable** : Le score et l'historique des tirs sont représentés par des structures immuables.
- **Récursivité** : La séance de tirs au but est simulée de manière récursive.
- **Affichage de l'historique** : Un récapitulatif détaillé de chaque tir est affiché, ainsi que le vainqueur de la séance.
- **Gestion des erreurs** : Emploi du pattern Option pour éviter les exceptions liées aux valeurs nulles ou aux erreurs de formatage.
- **Rejouer une partie** : Possibilité de rejouer une partie depuis le début ou un moment précis à partir de l'historique.
- **Testabilité** : Code déterministe, ce qui facilite l'écriture de tests unitaires.

## Exigences

- **Framework .NET** : Version 6.0 ou supérieure.
- **Outils de test** : NUnit ou xUnit (pour les tests unitaires).

## Installation et exécution

1. **Cloner le projet** :
   ```bash
   git clone https://github.com/votre-repo/penalty-shootout-simulation.git
   cd penalty-shootout-simulation
   ```

2. **Restaurer les dépendances** :
   ```bash
   dotnet restore
   ```

3. **Exécuter le projet** :
   ```bash
   dotnet run
   ```

4. **Exécuter les tests unitaires** :
   ```bash
   dotnet test
   ```

## Utilisation

Lorsque vous exécutez le projet, une séance de tirs au but est simulée automatiquement. Voici un exemple de sortie :

```
Tir 1 : Score : 1/0 (Équipe A : +1 | Équipe B : 0)
Tir 2 : Score : 1/1 (Équipe A : 0 | Équipe B : +1)
Tir 3 : Score : 2/1 (Équipe A : +1 | Équipe B : 0)
Tir 4 : Score : 2/2 (Équipe A : 0 | Équipe B : +1)
Tir 5 : Score : 3/2 (Équipe A : +1 | Équipe B : 0)
Victoire : Équipe A (Score : 3/2)
```

## Structure du projet
-  Dossier **`Models`** : Contient les classes suivantes 
   - **`PenaltyShootout.cs`** : Contient la logique principale de la simulation.
   - **`Option.cs`** : Implémentation du pattern Option pour gérer les erreurs fonctionnellement.
- Projet **`Tests`** : Ensemble de tests unitaires validant le comportement des fonctions principales.

## Concepts de programmation fonctionnelle

Ce projet met en œuvre les concepts suivants :

1. **Immuabilité** : Les structures de données, comme le score et l'historique, ne sont jamais modifiées directement.
2. **Récursivité** : La boucle principale utilise une fonction récursive pour simuler les tirs au but.
3. **Fonctions pures** : Les fonctions ne produisent pas d'effets de bord.
4. **Gestion des erreurs** : Utilisation du pattern Option pour éviter les exceptions et gérer les cas où une valeur peut être absente.

## Tests unitaires

Des tests unitaires sont inclus pour valider les fonctionnalités suivantes :

- Simulation d'un tir (but ou échec).
- Calcul du score après chaque tir.
- Détermination correcte du vainqueur.
- Gestion des cas où l'historique est vide ou mal formaté.

## Auteur

- **Laurine Carlier**  
  Contact : [laurine.carlier@stagiairesmns.fr](mailto:laurine.carlier@stagiairesmns.fr)


