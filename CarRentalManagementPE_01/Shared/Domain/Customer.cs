namespace CarRentalManagementPE_01.Shared.Domain
{
    public class Customer:BaseDomainModel
    {
        public virtual string? DrivingLicense { get; set; }
        public virtual string? Address { get; set; }
        public virtual string? ContactNumber { get; set; }
        public virtual string? EmailAddress { get; set; }
        public virtual List<Booking>? Bookings { get; set; }

    }
}