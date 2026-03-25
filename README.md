# 💰 FinStream-Hybrid

**L'alliance de la productivité .NET et de la performance Rust.**

FinStream-Hybrid est un gestionnaire de finances personnelles conçu pour démontrer une architecture **polyglotte** moderne. L'application utilise **C#** pour la gestion du domaine métier et des APIs, et **Rust** pour un moteur d'analyse haute performance.

---

## 🏗️ Architecture du Système

Le projet repose sur une communication **gRPC** binaire, garantissant une latence minimale et un typage strict entre les services.

* **Backend API (C# / .NET 10)** : Gère l'authentification, les transactions CRUD et la persistence SQL via Entity Framework Core.
* **Analysis Engine (Rust)** : Un microservice dédié aux calculs intensifs (projections financières, détection d'anomalies) utilisant **Tonic** (gRPC).
* **Protobuf Contract** : Source de vérité unique pour les modèles de données partagés.

## 🚀 Pourquoi cette architecture ?

1.  **Productivité (C#)** : Développement rapide de l'API et de la logique métier complexe avec un écosystème mature.
2.  **Performance & Sécurité (Rust)** : Traitement massif de données sans les coûts du Garbage Collector et avec une sécurité mémoire garantie.
3.  **Interopérabilité** : Utilisation de **gRPC/Protobuf** pour éliminer les erreurs de communication entre les services.

## 🛠️ Stack Technique

| Composant | Technologie |
| :--- | :--- |
| **API Framework** | ASP.NET Core (Minimal APIs) |
| **Compute Engine** | Rust (Tonic / Tokio) |
| **Database** | SQL Server / PostgreSQL (EF Core) |
| **Communication** | gRPC / Protocol Buffers |
| **Frontend** | Angular / Blazor SPA (Prévu) |

## ⚙️ Installation (Work in Progress)

```bash
# Cloner le repo
git clone [https://github.com/TON_USER/FinStream-Hybrid.git](https://github.com/TON_USER/FinStream-Hybrid.git)

# Lancer l'API C#
cd backend-api && dotnet run

# Lancer le moteur Rust
cd analysis-engine && cargo run
