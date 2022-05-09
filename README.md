# OrenesChallenge
Orenes Back-end Developer Challenge

A parcel delivery company has created a new feature for its customers that allows them to track in real time where their order is and in which vehicle.

Currently, it already has a mobile application and a website, so you are asked to create a new back-end API with which vehicles can connect and add orders to your delivery and users can get the current position of their order and the vehicle that will make the delivery by indicating the order number. You can work with Global Positioning System data points (geographic coordinates).

## Level 1
Create an API, as well as the data model, to insert, update and obtain the location of the vehicles. Once this step is done, it will be necessary to provide our API to be able to add/delete new orders to the existing vehicles.

In addition, it is necessary to ensure that the data model allows the vehicle location to be updated and the location history to be saved.

## Level 2
Instead of forcing customers to query/polling on locations, notify interested parties in real time of each location update.

Suggestion: WebHooks? MQTT?

# Solution
## Requirements
* .NET 5
* Visual Studio 2019
* Docker / Docker Compose
* Open ports in localhost:


| Component      |      Ports |
|----------------|------------|
| VehicleService | 5010, 5011 |
| SQL Server     | 5434       |
| Id. Service    | 5020, 5021 |
| ClientAppMVc   | 5030       |

Run this command at the same directory of docker-compose.yml file
```
docker-compose build
docker-compose up -d
```
You should be able to browse the ClientAppMvc using this URL:
```
http://localhost:5030/
```

# Components
## VehicleService
Backend service with Domain-Driven Design architecture. 
### VehicleService.API
Main project of the component. WebAPI project that exposes endpoints to manage Vehicle and Orders. It uses a mediator pattern (MediatR implementation) to communicate the request to the application layer. Every use case is managed by a command handler or a query at application level.
It implements a CQRS pattern to separate the model for insert/update/delete information from the model to read information.

The Insert/Update/Delete model is implemented using commands and command handlers. These handlers communicate with Domain layer using the repository implementations at infrastructure level

The read model is implemented using the Dapper ORM to improve the performance of the queries.

Also at application level, it is implemented the domain event handlers, so that every time a domain entity raises a domain event, the application layer can handle it, for example, to communicate to external systems.

The component is secured so that the endpoints need a bearer token validate by the Idp service to be used.

Endpoints documentation can be found at:
```
http://localhost:5010/swagger/index.html
https://localhost:5011/swagger/index.html
```

### VehicleService.Domain
Class library project that encapsulates the business domain. It defines the business logic, the domain entities and the interfaces to communicate to other layers.
All entities implement the Entity abstract class and only the entities that implement the IAggregateRoot interface can persist on its own.

Domain entities:
* Vehicle
* Order
* HistoricalLocation

### VehicleService.Infrastructure
Class library project that encapsulates the logic to communicate to external systems like databases. Here we implemented the repositories and context to communicate to a SQL Server database using EF Core.

A mediator extension method has been also implemented in order to manage domain events before a domain entitie persists.


## SQL Server
Instance of SQL Server 2019
sa pass: Pass@word

## Idp
Identity Service Provider. It was implemented as a machine to machine scenario with client credentials

## ClientAppMvc
Sample client app to make use of the endpoints exposed by VehicleService API

URLs

List of Vehicles and location updates:
```
http://localhost:5030/Vehicles
```

Add orders, delete orders, and get orders location:

```
http://localhost:5030/Orders
```