namespace RentalCar.Model.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        public string path { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}