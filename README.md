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
.NET 5
Docker / Docker Compose
Open ports in localhost:
| Component      |      Ports |
|----------------|------------|
| VehicleService | 5010, 5011 |
| SQL Server     | 5434       |
| Idp            | 5020, 5021 |
| ClientAppMVc   | 5030, 5031 |