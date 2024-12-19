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

- **Framework .NET** : Version 8.0.
- **Outils de test** : MSTests (pour les tests unitaires).
  
## Prérequis

- Visual Studio v17.12
  
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

### Pour exécuter le projet : 
- Il est possible de cliquer sur le bouton play en haut de l'écran
- Sinon, le raccourci CTRL + F5 permet de lancer la solution

La console s'ouvre automatiquement, affichant les résultats. 

### Pour exécuter les tests : 
- Dans l'arborescence à droite, faire un clic droit sur le projet de tests **`PenaltyShootoutTests`**
- Puis cliquer sur "Exécuter les tests"

Une fenêtre s'ouvre, affichant les résultats des tests.

## Structure du projet
- Dossier **`Models`** : Contient les classes suivantes 
   - **`PenaltyShootout.cs`** : Contient la logique principale de la simulation.
   - **`Option.cs`** : Implémentation du pattern Option pour gérer les erreurs fonctionnellement.
- Projet **`PenaltyShootoutTests`** : Ensemble de tests unitaires validant le comportement des fonctions principales.

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


