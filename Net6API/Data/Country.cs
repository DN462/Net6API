namespace Net6API.Data
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryNameAcronym { get; set; }

        public ICollection<UserInformation> Users { get; set; }
    }
}