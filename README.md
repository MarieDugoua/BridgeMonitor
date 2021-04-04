# TP C# dotnet

## Pont-chaban B2 2020/2021

### BridgeMonitor - Marie Dugoua

- Sources :

  - [StackOverflow](https://stackoverflow.com/)
  - [Docs microsoft](https://docs.microsoft.com/fr-fr/aspnet/core/?view=aspnetcore-5.0)
  - [GitHub Thomas Auriol](https://github.com/Nimeryon/BridgeMonitor)
  - [GitHub Mattéo Christophe](https://github.com/Matteo-Ynov/BridgeMonitor)

  

- **Structure de base :**

  1. Créer un repository public sur github, bitbucket ou gitlab pour héberger votre code que vous intitulerez **BridgeMonitor**
  2. Publier votre code sur le repository à chaque avancée **(attention, si l'historique ne présente pas les commits au fur et à mesure de votre avancée, cela pourra être pénalisé)**
  3. L'application doit compiler et se lancer sans problème.

  

- **Page d'accueil "prochaine fermeture" :**

  Votre application doit avoir pour page d'accueil une page intitulée "Prochaine fermeture" qui doit donner des informations sur la date de la prochaine prochaine fermeture du pont chaban delmas.

  Cette page doit indiquer :

  - La date et heure de la fermeture (avec le nom du jour de la semaine)

  - La date et heure de la réouverture

  - Le nom du bateau ou évènement responsable de la fermeture

  - La durée de la prochaine fermeture

  - Un décompte en temps réel de la forme "encore 5 jours, 3 heures 2 minutes et 17 secondes avant la prochaine fermeture" 

  - Un indicateur "Risque de bouchons" qui affichera

    - "Elevé" si la fermeture impacte la plage horaire "7h-9h" ou "17h-19h"

    - "Faible" sinon

      

- **Page "Toutes les fermetures" :**

  Votre application doit comporter une page "Toutes les fermetures" qui va afficher toutes les fermetures du pont chaban delmas retournées par l'API sous forme de 2 tableaux.

  Un premier tableau, avec uniquement les fermetures à venir.

  Un deuxième tableau, avec uniquement les fermetures déjà passées.

  Chaque tableau aura les colonnes suivantes

  - Nom du bateau ou de l'évènement responsable de la fermeture
  - Date et heure de la prochaine fermeture
  - Durée de la prochaine fermeture

  Dans ce tableau, les lignes seront triées par date (la dernière ligne du tableau comportera donc la fermeture la plus lointaine).

  

- **Page "Détail d'une fermeture" :**

  Dans la page "Toutes les fermetures", ajouter sur chaque ligne un lien "Voir le détail" qui permettra au clic d'accéder à une page de détail qui donnera exactement le même niveau de détail pour la fermeture sélectionnée que ce qui est visible sur la page d'accueil pour la prochaine fermeture .