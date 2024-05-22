# Exercice de live coding

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
* Quel est le revenu déclaré moyen en France ?
* Quelle est la commune avec le plus faible revenu déclaré médian ? Qu'en pensez vous ?
* Quelle sont les 5 communes avec les plus forts revenus fiscaux totaux pour l’État et les collectivités locales ? 
* Quelle sont les 5 communes qui profitent le plus de la redistribution ?
* Existe-t-il une corrélation entre le taux de familles monoparentales et le revenu déclaré médian ?
* Existe-t-il une corrélation entre la jeunesse des habitants d'une commune et le revenu déclaré médian ?

# Exercices de mathématique
## Exercice 1
On note $i$ le nombre complexe tel que $i^2=-1$. Combien vaut $i^i$ ?

## Exercice 2
Soit $M$ la matrice $\begin{pmatrix}
0 & 1\\
1 & 0
\end{pmatrix}$

Soit $n$ un nombre entier. Calculer $M^n$. En donner une interprétation géométrique.

# Exercices de machine learning
## Exercice 1
Lors d'un travail de mise au point d'un algorithme de machine learning, comment détectez vous le sur-apprentissage ? Si vous détecter du sur-apprentissage quelles sont les pistes classiques pour le limiter ?
## Exercice 2
Vous disposez d'un ensemble d'apprentissage pour entraîner un modèle de machine learning dans lequel il existe des variables (=features) catégorielles. Comment encodez vous ces variables dans le modèle ? Quels sont les différents cas de figure ?