namespace Onsight.ApiClient.Abstractions.Commands.Customers
{
    public class CustomerCreateCommand
    {
        public string Name { get; init; } = null!;

        public string? ExternalKey { get; init; } 
        public string? Comment { get; init; } 
        public string? Email { get; init; } 
        public string? TaxNumber { get; init; } 
        public bool? IsTaxable { get; init; } 
        public string? BillingAddress1 { get; init; } 
        public string? BillingAddress2 { get; init; } 
        public string? BillingCity { get; init; } 
        public string? BillingCountry { get; init; } 
        public string? BillingPostalCode { get; init; } 
        public string? BillingState { get; init; } 
        public string? ShippingAddress1 { get; init; } 
        public string? ShippingAddress2 { get; init; } 
        public string? ShippingCity { get; init; } 
        public string? ShippingCountry { get; init; } 
        public string? ShippingPostalCode { get; init; } 
        public string? ShippingState { get; init; } 
        public string? GpsCoordinates { get; init; } 
    }
}