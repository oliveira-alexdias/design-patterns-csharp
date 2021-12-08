namespace Facade.Entity
{
    public class Address
    {
        public Address(string streetName, string streetNumber, string cityName, string stateName, string zipCode)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            CityName = cityName;
            StateName = stateName;
            ZipCode = zipCode;
        }

        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
    }
}