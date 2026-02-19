# TimeTravelAgency

Application web de voyage temporel développée avec ASP.NET Core MVC, Docker et déployée sur le cloud.

# Lien de l'application déploiyer en ligne via Render : 
https://timetravelagency-u1ma.onrender.com

# Lien du repot GtHub:
https://github.com/CarlaWAHA/TimeTravelAgency.git

# Stack technique :

Backend : ASP.NET Core MVC (.NET 8 LTS)
Frontend : Razor Views + CSS personnalisé (thème sombre premium)
Conteneurisation : Docker (multi-stage build)
Hébergement : Render (Cloud)
Versioning : GitHub

# Fonctionalité intégrer :

 Landing page premium avec hero section immersive
  Navigation multi-pages (Accueil, Destinations, Réserver)
  Présentation de 3 destinations :
  Formulaire de réservation
Architecture MVC structurée
Déploiement cloud accessible publiquement




 # Difficultés Techniques Résolues
  Gestion du contexte Docker et chemins COPY
  Compatibilité .NET 9 → .NET 8
  Configuration du build context sur Render
  Debug des erreurs de compilation en environnement cloud



 # Perspectives d'Amélioration 
  Intégration complète d'un chatbot IA conversationnel
  Ajout d'une base de données (SQL ou NoSQL)
  Amélioration UX/UI avancée
  Mise en place d'un système d'authentification



# Notre page d’accueil  

Dans notre hero section nous avons choisis d’ajouter le titre de l’entreprise (TimeTravel) une vidéo immersive en background. Il contient un explorer des destinations et un conseiller IA. 

Nous ajoutons le présentation de l’entreprise notemment avec :  

Concept de voyage temporel de luxe 

Expertise historique 

Sécurité et technologie avancée 

Positionnement premium 

Galerie des Destinations (Section clé) 

Destinations proposées : Paris 1889 — Exposition Universelle 

Highlights : 
    Inauguration de la Tour Eiffel 
    Belle Époque 
    Effervescence artistique et industrielle 

Crétacé — 65 Millions d’années 
Highlights : 
    Dinosaures en milieu naturel 
    Exploration préhistorique 
    Expérience immersive extrême 

Florence 1504 — Renaissance Italienne 
Highlights : 
    Florence à l’apogée artistique 
    Michel-Ange et le David 
    architecture et humanisme 

 

Fonctionnalités des Cards 

Chaque card inclut : 

    Image immersive 
    Titre + époque 
    Description courte 
    Bouton “Découvrir” 
    Hover effect (zoom léger) 
    Lazy loading des images 

 

Page Détail Destination 

Pour chaque destination : 

Hero spécifique 

Description longue immersive 

Activités proposées 

Prix indicatif : (Paris 1889 : 4 900€, Florence 1504 : 5 200€, Crétacé : 12 000€) 

Bouton “Réserver” 

 

Agent Conversationnel IA 

Widget en bas à droite : 

Icône flottante 

Fenêtre modale 

Thème sombre + accents dorés 

Capacité du chatbot : 

Conseils personnalisés 

Comparaison des destinations 

Recommandation selon profil 

FAQ automatique 

Simulation de prix 

Personnalité définie : 

Assistant virtuel de luxe 
Professionnel, passionné d’histoire 
Enthousiaste mais crédible 
Expert des 3 périodes 

 
 
# Formulaire de Réservation 

    Champs : 

        Destination 
        Dates souhaitées 
        Nombre de voyageurs 
        Préférences 
        Email 

    Fonctions : 
        Validation automatique 
        Confirmation simulée 

# IA Utilisée

Modèle : Mistral Small

API : Mistral AI

Personnalité configurée via System Prompt

Génération et assistance au développement : ChatGPT