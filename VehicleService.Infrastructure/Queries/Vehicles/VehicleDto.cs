namespace VehicleService.Infrastructure.Queries.Vehicles
{
    public record VehicleDto
    {
        public int Id { get; set; }
        public string  LicensePlate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int NumOrders { get; set; }
        
    }
}
