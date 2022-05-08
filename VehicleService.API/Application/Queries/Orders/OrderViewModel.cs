namespace VehicleService.API.Application.Queries.Orders
{
    public record OrderViewModel
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string TrackingCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
