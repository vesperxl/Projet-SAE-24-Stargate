# 🚀 Projet Stargate — SAÉ24 Session 2026

> *"Capitaine ALGLAVE, matricule MCD-413, au rapport pour le briefing de mission, mon général !"*

---

<div align="center">
  <img src="https://images.unsplash.com/photo-1446776811953-b23d57bd21aa?w=900&q=80" alt="Bannière Stargate — vue de la Terre depuis l'espace" width="100%" style="border-radius:12px"/>
</div>

<br/>

<div align="center">

![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-Database-003B57?style=for-the-badge&logo=sqlite&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-En%20cours-yellow?style=for-the-badge)

</div>

---

## 🌌 Présentation

<div align="center">
  <img src="https://images.unsplash.com/photo-1462331940025-496dfbfc7564?w=800&q=80" alt="Galaxie — univers Stargate" width="75%"/>
</div>

**Stargate** est une application de gestion de missions interstellaires développée dans le cadre du projet **SAÉ24** du département informatique de l'IUT Robert Schuman.

Dans un futur proche, l'humanité a établi des contacts avec plusieurs espèces extraterrestres peuplant notre galaxie. Les enjeux sont colossaux : échanges militaires, négociations économiques, et surtout la convoitise autour du **DataBaz** — un minerai rarissime présent sur quelques planètes seulement, prisé par les industriels et politiciens terriens.

L'application Stargate centralise l'ensemble de la logistique opérationnelle : planification des missions, gestion des équipages, suivi budgétaire, journal de bord, et renseignements sur les races et planètes répertoriées.

---

## 🛠️ Stack technique

| Technologie | Usage |
|---|---|
| **C# / WinForms** | Interface graphique desktop |
| **SQLite** (`Stargate.db`) | Base de données locale |
| **ADO.NET** (mode connecté/déconnecté) | Accès aux données |
| **DataSet local** | Cache et partage de données inter-formulaires |
| **Hachage (SHA-256)** | Authentification administrateur sécurisée |
| **iTextSharp / PDFSharp** | Génération de rapports PDF |

---

## ⚙️ Installation & Exécution

### Prérequis

- **.NET Framework 4.8** ou supérieur (ou .NET 6+ selon la version ciblée)
- **Visual Studio 2022** (Community ou supérieur)
- Le fichier **`Stargate.db`** fourni (base SQLite pré-peuplée)
- La classe **`Connexion.cs`** disponible sur Moodle
- La classe **`mesDatas.cs`** disponible sur Moodle

### Étapes d'installation

1. **Cloner ou télécharger** le dépôt du projet :
   ```bash
   git clone https://github.com/votre-repo/projet-stargate.git
   cd projet-stargate
   ```

2. **Ouvrir la solution** dans Visual Studio :
   ```
   Stargate.sln
   ```

3. **Ajouter les fichiers Moodle** dans le projet :
   - Copier `Connexion.cs` à la racine du projet
   - Copier `mesDatas.cs` à la racine du projet

4. **Placer la base de données** `Stargate.db` dans le répertoire de sortie (généralement `bin/Debug/` ou `bin/Release/`).

5. **Restaurer les packages NuGet** si nécessaire (clic droit sur la solution → *Restore NuGet Packages*).

6. **Compiler et lancer** le projet (`F5` ou bouton *Démarrer*).

### Connexion administrateur

L'accès aux fonctionnalités de création de mission est restreint. Utilisez les identifiants administrateur stockés dans la table `Admin` de la base (`login` + mot de passe haché).

> ⚠️ Le mot de passe est stocké sous forme **hachée** dans la base de données. Ne jamais modifier ce champ manuellement sans passer par l'algorithme de hachage correspondant.

---

## 🧭 Fonctionnalités

### 🗂️ Volet 1 — Tableau de bord des missions

Vue d'ensemble synthétique de toutes les missions (passées, en cours, à venir). Chaque carte affiche :
- Nom de la mission et planète cible
- Dates de départ et de retour prévue
- Nom du chef de mission
- Budget alloué

➡️ Possibilité d'**éditer un rapport PDF** de bilan directement depuis le tableau de bord.

---

### ➕ Volet 2 — Création d'une nouvelle mission *(Administrateurs uniquement)*

Accès restreint via formulaire d'authentification (login + mot de passe haché).

Création en plusieurs étapes :
1. **Choix de la planète cible** → génère automatiquement le nom de la mission
2. **Sélection du chef de mission** (obligatoirement un militaire)
3. **Paramétrage** : dates de départ/retour, feuille de route, nombre de membres, objectif DataBaz en tonnes, budget
4. **Affectation de l'équipage** (civils et militaires)
5. **Définition des objectifs de captures** par espèce ennemie *(saisie via transaction — toute anomalie annule l'ensemble des captures)*

---

### 📋 Volet 3 — Récapitulatif complet d'une mission *(Mode déconnecté)*

Fiche détaillée accessible depuis le tableau de bord :

**Partie 1 — Informations générales :**
- Dates de départ et de retour prévue
- Feuille de route et objectifs de capture
- Budget initial et solde actuel
- Liste des membres de l'équipage (civils & militaires) et chef de mission

**Partie 2 — Journal de bord** *(via bouton "Accès au journal")*  
*(Navigation par liaison de données — aucun accès BDD requis pour passer d'un événement à l'autre)*
- Chronologie des événements depuis le départ
- Dépenses effectuées (date, motif, montant, type)
- Contacts avec les informateurs extraterrestres (nom de code, espèce, somme versée, appréciation)
- Bilan des captures par espèce (objectif initial / captures réalisées / taux de réussite %)

Tant que la mission est en cours, il est possible d'**ajouter** des contacts, dépenses et événements.

---

### 🔭 Volet 4 — Événements du journal *(Mode liaison de données)*

Visualisation chronologique et individuelle des événements d'une mission via boutons de navigation (`<<` `<` `>` `>>`).

> Navigation 100% en liaison de données — aucune requête SQL lors de la navigation.

---

### 👽 Volet 5 — Races répertoriées *(Mode déconnecté)*

<div align="center">
  <img src="https://images.unsplash.com/photo-1451187580459-43490279c0fa?w=800&q=80" alt="Univers extraterrestre" width="75%"/>
</div>

Galerie visuelle des espèces extraterrestres connues, avec filtres par nom et couleur.

Pour chaque espèce :
- **Espèces ennemies** : nom, couleur, type d'arme, degré d'agressivité
- **Espèces alliées** : nom, couleur, date de premier contact, degré de bienveillance, instrument de musique favori

---

### 🪐 Volet 6 — Informations sur les planètes *(Mode déconnecté)*

<div align="center">
  <img src="https://images.unsplash.com/photo-1614730321146-b6fa6a46bcb4?w=800&q=80" alt="Planètes de la galaxie" width="80%"/>
</div>

Galerie des planètes de la galaxie avec pour chacune :
- Atmosphère, température, gravité
- Présence ou absence de DataBaz
- Races présentes et leur pourcentage de représentation (alliées et ennemies)
- Missions déjà effectuées sur la planète

---

### 📊 Volet 7 — Statistiques

Requêtes analytiques disponibles dans l'application :

| # | Requête |
|---|---|
| 1 | Liste des co-équipiers d'un membre sélectionné (toutes missions confondues) |
| 2 | Dépenses et budgets des missions à équipage de plus de 10 personnes |
| 3 | Nombre de missions par planète (y compris planètes sans mission) |
| 4 | Dépenses les plus élevées par mission avec nom du chef de mission |
| 5 | Informateurs ayant reçu le moins d'argent pour une mission donnée |

---

## 🗄️ Schéma de la base de données

La base `Stargate.db` (SQLite) repose sur les tables suivantes :

```
Planete          → nom, temperature, gravite, dataBazON
Mission          → numero, nomPlanete, nbMembreRequis, dateDepart, dateRetour,
                   matriculeChef, feuilleDeRoute, objectifDatabaz, budget
Membre           → matricule, nom, prenom, dateNaissance
Civil            → matriculeMembre, Specialite, nomPlaneteOrigine
Militaire        → matriculeMembre, grade
Composer         → nomPlanete, numeroMission, matriculeMembre  (équipage)
Espece           → id, nom, couleur
Allie            → idEspece, datePremierContact, degreBienveillance, instrumentMusique
Ennemi           → idEspece, typeArme, degreAgressivite
Habiter          → nomPlanete, idEspece, pourcentage
ObjectifCapture  → nomPlanete, numeroMission, idEspeceEnnemi, objectif
Capturer         → nomPlanete, numeroMission, idEspeceEnnemi, nombre
Negocier         → nomPlanete, numeroMission, idEspeceAllie, dataBaz
Depense          → id, nomPlanete, numeroMission, dateD, montant, motif, idTypeDepense
TypeDepense      → id, libelle
JournalDeBord    → nomPlanete, numeroMission, dateJ, commentaires
Contact          → nomPlanete, numeroMission, dateC, sommeVersee, appreciation,
                   nomCodeInformateur
Informateur      → nomCode, nom, idEspeceEnnemi, commentaires
Admin            → login, mdp
```

---

## 📁 Structure du projet

```
Stargate/
├── Stargate.sln
├── Stargate.db                  ← Base de données SQLite
├── README.md
└── Stargate/
    ├── Program.cs
    ├── Connexion.cs             ← Gestion ouverture/fermeture BDD (Moodle)
    ├── mesDatas.cs              ← DataSet partagé inter-formulaires (Moodle)
    ├── Forms/
    │   ├── FormTableauDeBord.cs
    │   ├── FormAuthentification.cs
    │   ├── FormNouveleMission.cs
    │   ├── FormFicheMission.cs
    │   ├── FormJournalDeBord.cs
    │   ├── FormRaces.cs
    │   └── FormPlanetes.cs
    └── Resources/
        └── images/              ← Images espèces, planètes, icônes UI
```

---

## 👥 Auteurs

Projet réalisé dans le cadre de la **SAÉ24 — session 2026**  
Département Informatique — **IUT Robert Schuman**

---

## 📄 Licence

Projet académique — usage interne IUT Robert Schuman uniquement.  
Toute redistribution externe est soumise à l'accord des enseignants référents.

---

> *"Vous allez intégrer la mission SCKXYSS-1… ce sera vous, mon capitaine."* 🛸
