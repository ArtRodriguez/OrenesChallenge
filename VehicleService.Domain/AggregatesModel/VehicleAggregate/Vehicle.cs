﻿using System;
using System.Collections.Generic;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.Events;
using VehicleService.Domain.Exceptions;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Domain.AggregatesModel.VehicleAggregate
{
    public class Vehicle : Entity, IAggregateRoot
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string LicensePlate { get; private set; }
        private readonly List<HistoricalLocation> _historicalLocations;
        private readonly List<Order> _orders;

        public IReadOnlyCollection<HistoricalLocation> HistoricalLocations => _historicalLocations;
        public IReadOnlyCollection<Order> Orders => _orders;

        public Vehicle()
        {
            _historicalLocations = new List<HistoricalLocation>();
            _orders = new List<Order>();
        }
        public Vehicle(int id, double latitude, double longitude, string licensePlate) : this()
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
            LicensePlate = licensePlate;
        }
        /// <summary>
        /// Updates the current position of the vehicle and keeps track of it
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public void UpdateLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            UpdatedAt = DateTime.Now;
            _historicalLocations.Add(new HistoricalLocation(Id, latitude, longitude));
            AddDomainEvent(new VehicleLocationUpdatedDomainEvent(this));
        }

        /// <summary>
        /// Adds a new order to a Vehicle
        /// </summary>
        /// <param name="trackingCode"></param>
        public void AddOrder(string trackingCode)
        {
            // Domain rule: a vehicle cannot have more than 50 orders
            // Check capacity
            if (_orders.Count >= 50)
            {
                throw new FullVehicleDomainException($"Vehicle {Id} is full and cannot accept new orders");
            }
            var order = new Order(Id, trackingCode);
            _orders.Add(order);
        }

        public void RemoveOrderByTrackingCode(string trackingCode)
        {
            _orders.Remove(_orders.Find(x => x.TrackingCode == trackingCode));
        }
    }
}
