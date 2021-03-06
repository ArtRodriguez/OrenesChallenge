using System;
using System.Collections.Generic;
using System.Linq;
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
            Latitude = CheckLatitude(latitude);
            Longitude = CheckLongitude(longitude);            
            LicensePlate = licensePlate;
        }
        /// <summary>
        /// Updates the current position of the vehicle and keeps track of it
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public void UpdateLocation(double latitude, double longitude)
        {
            if(Latitude == CheckLatitude(latitude) && Longitude == CheckLongitude(longitude))
            {
                return;
            }
            var previousLatitude = Latitude;
            var previousLongitude = Longitude;
            Latitude = latitude;
            Longitude = longitude;
            UpdatedAt = DateTime.Now;
            _historicalLocations.Add(new HistoricalLocation(Id, latitude, longitude));
            AddDomainEvent(new VehicleLocationUpdatedDomainEvent(this, previousLatitude, previousLongitude));
        }

        /// <summary>
        /// Adds a new order to a Vehicle
        /// </summary>
        /// <param name="trackingCode"></param>
        public void AddOrder(string trackingCode)
        {
            // Domain rule: a vehicle cannot have more than 50 orders
            // Check capacity
            if (MaxCapacityReached())
            {
                throw new FullVehicleDomainException($"Vehicle {Id} is full and cannot accept new orders");
            }
            var order = new Order(Id, trackingCode);
            _orders.Add(order);
        }      

        /// <summary>
        /// Deletes a order from a vehicle
        /// </summary>
        /// <param name="trackingCode"></param>
        public void DeleteOrder(string trackingCode)
        {
            _orders.Remove(_orders.FirstOrDefault(x => x.TrackingCode == trackingCode));
        }
        /// <summary>
        /// Checks if the vehicle reached its max capacity
        /// </summary>
        /// <returns></returns>
        public virtual bool MaxCapacityReached()
        {
            return _orders?.Count >= 50;
        }

        private double CheckLatitude(double latitude)
        {
            if (latitude > 90 || latitude < -90)
            {
                throw new ArgumentException(nameof(latitude));
            }
            return latitude;
        }
        private double CheckLongitude(double longitude)
        {
            if (longitude > 180 || longitude < -180)
            {
                throw new ArgumentException(nameof(longitude));
            }
            return longitude;
        }
    }
}
