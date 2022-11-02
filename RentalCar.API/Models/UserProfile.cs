namespace RentalCar.API.Models
{
    public class UserProfile
    {
        public string Fullname { get; set; }

        public string Contact { get; set; }

        public string ProfileImage { get; set; }
        
        public string CCCDImage { get; set; }

        public string Gender { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string Username { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdateAt { get; set; }
        
        public string Address { get; set; }
        
        public string Ward { get; set; }

        public string District { get; set; }
    }
}