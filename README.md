# Exercice de manipulations de données en Python

## Environnement
Pour réaliser cet exercice vous devez disposer d'un environnement python avec les packages suivants
* pandas.
* scikit-learn ou scipy.
* un package de visualisation de type matplotlib ou plotly n'est pas obligatoire mais peut-être utile.

Le code pourra être réalisé sur un notebook jupyter ou à défaut directement dans un script python.

L'exercice dure 45 minutes. Vous devez aller le plus loin possible. Il est normal de ne pas le finir dans le délai imparti. 

## Description des données
Vous disposez de 5 tables issues de données de l'INSEE sur les communes françaises en 2020 :
* `communes.csv` : liste des communes en 2020
    * `code_commune` : code INSEE unique pour chaque commune. Les 2 premiers numéros correspondent au département.
    * `nom_commune` : nom de la commune
* `familles.csv` : description des familles pour chaque commune
    * `code_commune` : code INSEE unique pour chaque commune. Les 2 premiers numéros correspondent au département.
    * `nb_familles` : nombre de familles dans la commune.
    * `nb_familles_monoparentales` : nombre de familles monoparentales dans la commune.
* `pyramides_ages.csv` : pyramide des âges
    * `code_commune` : code INSEE unique pour chaque commune. Les 2 premiers numéros correspondent au département.
    * `pop_00_14` : population entre 0 et 14 ans
    * `pop_15_29` : population entre 15 et 29 ans
    * `pop_30_44` : population entre 30 et 44 ans
    * `pop_45_59` : population entre 45 et 59 ans
    * `pop_60_74` : population entre 60 et 74 ans
    * `pop_75_89` : population entre 75 et 89 ans
    * `pop_90_p` : population de plus de 90 ans
* `revenus_declares.csv` : revenus déclarés aux impôts
    * `code_commune` : code INSEE unique pour chaque commune. Les 2 premiers numéros correspondent au département. 
    * `nb_menages_fiscaux` : nombre de ménages fiscaux
    * `nb_personnes` : nombre total de personnes dans ces ménages
    * `revenu_median_declare` : revenu médian déclaré.
* `revenus_disponibles.csv` : revenus disponibles après impôts et redistribution
    * `code_commune` : code INSEE unique pour chaque commune. Les 2 premiers numéros correspondent au département. 
    * `nb_menages_fiscaux` : nombre de ménages fiscaux
    * `nb_personnes` : nombre total de personnes dans ces ménages
    * `revenu_median_disponible` : revenu médian déclaré.

Pour les besoins de l'exercice, on assimilera le revenu médian et le revenu moyen. 

## Questions
* Quel est le revenu déclaré moyen d'un ménage en France ?
* Quelle est la commune avec le plus faible revenu déclaré médian ? Qu'en pensez vous ?
* Quelle sont les 5 communes avec les plus forts revenus fiscaux totaux pour l’État et les collectivités locales ? 
* Quelle sont les 5 communes qui profitent le plus de la redistribution ?
* Existe-t-il une corrélation entre le taux de familles monoparentales et le revenu déclaré médian ?
* Existe-t-il une corrélation entre la jeunesse des habitants d'une commune et le revenu déclaré médian ?

# Exercice C# et .NET

## Environnement

Pour réaliser cet exercice, vous devez disposer d'un environnement [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) ou plus récent.
Il n'y a pas de code à produire (les réponses attendues sont assez simples pour être décrites oralement).

On considère une application (très) simplifiée de gestion d'équipes sportives (le sport ciblé est quelconque).

Le système enregistre des joueurs, des équipes, et pour faire le lien entre les deux, des contrats.
Un contrat lie un joueur à une équipe, possède une date de début ainsi qu'une date de fin (celle ci est `null` si le contrat est toujours en cours).
Un joueur peut avoir un nombre illimité de contrats au cours de sa carrière, faire des allers-retours entre différentes équipes, mais un seul contrat doit être actif à la fois.

Lors des périodes hivernales et estivales, il est courant de voir des équipes se séparer de plusieurs joueurs et en recruter d'autres.
On va s'intéresser au code métier permettant de mettre fin en une fois à des contrats concernant plusieurs joueurs.

## Questions

* Quel est l'intérêt d'avoir des paramètres génériques `TEntity` et `TKey` dans l'interface `IFullRepository` ?
* Examiner la méthode `TerminateContractsAsync` du `ContractService`. Quels sont les deux problèmes dans cette méthode et comment les corriger ?
* Bonus : comment améliorer le code "standard" fourni par l'interface `IFullRepository` et les interfaces qu'elle agrège (`ICreateRepository`, `IReadRepository`, etc.) ?

# Exercices de mathématique

Soit $M_2$ la matrice
```math
\begin{pmatrix}0&1\\1&0\end{pmatrix}
```

1. Soit $k$ un nombre entier positif. Calculer $M_2^k$.
2. Donner une interprétation géométrique de la transformation linéaire associée à $M_2$.
3. En déduire deux vecteurs propres et leurs deux valeurs propres associées.

Soit $M_3$ la matrice
```math
\begin{pmatrix}0&1&0\\0&0&1\\1&0&0\end{pmatrix}
```

4. Donner un vecteur propre évident ainsi que sa valeur propre associée. On pourra s'inspirer de ce qui a été remarqué à la question 3.
5. En déduire une interprétation géométrique de la transformation linéaire associée à $M_3$ ainsi qu'une interprétation géométrique associée à $^TM_3$.
7. Quel sont les angles associés à ces interprétations géométriques ?

Soit $\delta_n^p$ la fonction qui vaut 1 si $n=p$ et 0 sinon.

On note $\mod{}$ la fonction modulo. Exemple $5\mod{2}=1$

Soit $M_n$ la matrice dont les éléments sont notés $m^i_j$ avec $i,j \in \left[0,n-1\right]$ avec $m^i_j = \delta^{\left(i+1\right)\mod{n}}_j$.

7. Que vaut $M_n^{k.n}$ où $k$ est un entier ?
8. Quel est le lien entre l'ensemble des matrices $M_n^k$ où $k \in \left[0,n-1\right]$ et l'ensemble des nombres complexes $e^{k.i.\frac{2.\pi}{n}}$ où $k \in \left[0,n-1\right]$ ?
9. Retrouver les nombres complexes $e^{k.i.\frac{2.\pi}{2}}$ et $e^{k.i.\frac{2.\pi}{3}}$ dans les interprétations géométriques des transformations linéaires associées à $M_2$ et $M_3$.

Soit $M_{n,p}$ la matrice dont les éléments sont notés $m^i_j$ avec $i,j \in \left[0,n-1\right]$ avec $m^i_j = \delta^{\left(i+p\right)\mod{n}}_j$.

On note $I_n$ la matrice identité de dimension $n$

10. Quel est plus petit nombre entier strictement positif $k$ tel que $M^k_{n,p} = I_n$ ?

On note $\mathbb{1}$, le vecteur composé uniquement de $1$.

On considère l'ensemble des matrices $A$ composées uniquement de $0$ et de $1$ et telles que $^TA.A = I$ et telles que $\mathbb{1}$ est un vecteur propre dont la valeur propre est $1$.

11. Est-il vrai que pour une matrice $A$ donnée, il existe forcément un nombre $k$ tel que $A^k = I$ ?

# Exercices de machine learning
## Exercice 1
Lors d'un travail de mise au point d'un algorithme de machine learning, comment détectez vous le sur-apprentissage ? Si vous détecter du sur-apprentissage quelles sont les pistes classiques pour le limiter ?
## Exercice 2
Vous disposez d'un ensemble d'apprentissage pour entraîner un modèle de machine learning dans lequel il existe des variables (=features) catégorielles. Comment encodez vous ces variables dans le modèle ? Quels sont les différents cas de figure ?
