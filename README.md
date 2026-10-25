# CloudForge

**A cloud infrastructure management platform built with C# and ASP.NET Core.**

CloudForge is a personal software engineering project exploring the architecture and development of a multi-tenant Infrastructure as a Service (IaaS) control plane, inspired by cloud platforms such as AWS and DigitalOcean.

The long-term goal is to provide a centralised dashboard where organisations can provision, manage, and monitor cloud infrastructure resources.

> **Project Status:** Early Development — v0.1 (CloudForge Lite)

## Project Overview

CloudForge is being developed incrementally, starting with a RESTful API for managing simulated cloud instances.

The project focuses on backend engineering, cloud infrastructure concepts, asynchronous programming, and secure multi-tenant architecture.

The current version uses an in-memory database to support local development and API testing. No real cloud infrastructure is provisioned at this stage.

## Tech Stack

| Component | Technology |
|---|---|
| Language | C# |
| Backend Framework | ASP.NET Core 10 |
| ORM | Entity Framework Core |
| Database | EF Core InMemory (development) |
| API Architecture | REST |
| IDE | Visual Studio 2026 |
| Version Control | Git & GitHub |

**Planned technologies:** PostgreSQL, Docker, AWS SDK for .NET, and Blazor.

## Current Features

### v0.1 — API Foundation

- [x] ASP.NET Core Web API project setup
- [x] Health check endpoint
- [x] Entity Framework Core integration
- [x] In-memory database configuration
- [x] Instance CRUD API (scaffolded)
- [x] Manual API testing
- [x] GitHub repository initialisation
- [ ] Instance lifecycle management (Start/Stop)
- [ ] Instance status model
- [ ] Automated unit and integration tests

### Available API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/health` | Check API availability |
| GET | `/api/instances` | Retrieve all instances |
| GET | `/api/instances/{id}` | Retrieve an instance |
| POST | `/api/instances` | Create an instance record |
| PUT | `/api/instances/{id}` | Update an instance |
| DELETE | `/api/instances/{id}` | Delete an instance |

These endpoints currently manage simulated instance records rather than actual virtual machines.

## Getting Started

### Prerequisites

- .NET 10 SDK
- Visual Studio 2026 or another compatible development environment

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/hansenabong/CloudForge.git
cd CloudForge
```

**2. Restore dependencies**

```bash
dotnet restore
```

**3. Run the application**

```bash
dotnet run --project CloudForge.Api/CloudForge.Api.csproj
```

**4. Test the API**

Navigate to the HTTPS localhost address displayed in the terminal and append:

```text
/api/health
```

The expected response is:

```json
{
  "status": "healthy",
  "service": "CloudForge API",
  "version": "0.1"
}
```

The actual URL and port depend on your local launch configuration.

## Development Roadmap

### Phase 1 — Backend Foundation
- REST API and CRUD operations
- Instance lifecycle operations
- Input validation and error handling
- Automated testing

### Phase 2 — Database and Architecture
- PostgreSQL integration
- Service and repository abstractions where appropriate
- Background provisioning operations
- Resource state management

### Phase 3 — Multi-Tenancy
- User authentication
- Organisation management
- Role-based access control
- Tenant-level resource isolation

### Phase 4 — Infrastructure Integration
- AWS SDK integration
- Restricted EC2 instance management
- Provisioning status tracking
- Audit logging and resource quotas

### Phase 5 — Dashboard and Deployment
- Web-based management interface
- Docker containerisation
- CI/CD pipeline
- Cloud deployment and monitoring

## Learning Objectives

This project is also being used to strengthen practical skills in:

- C# and object-oriented programming
- ASP.NET Core application development
- RESTful API design
- Dependency injection
- Asynchronous programming
- Database design and Entity Framework Core
- Cloud infrastructure and secure multi-tenant systems

## Disclaimer

CloudForge is an educational portfolio project under active development. It is not a production-ready infrastructure hosting service.

## License

No open-source licence has been selected at this stage.
