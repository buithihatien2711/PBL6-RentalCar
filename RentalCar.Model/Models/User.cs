using System.ComponentModel.DataAnnotations;

namespace RentalCar.Model.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(256)]
        public string Fullname { get; set; }
        
        [MaxLength(20)]
        public string Contact { get; set; }
        
        [MaxLength(256)]
        public string ProfileImage { get; set; }
        
        [MaxLength(256)]
        public string CCCDImage { get; set; }
        
        [MaxLength(20)]
        public string Gender { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        [MaxLength(20)]
        public string Username { get; set; }
        
        public byte[] PasswordSalt { get; set; }
        
        public byte[] PasswordHash { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdateAt { get; set; }

        public int LocationId { get; set; }
        
        public Location Location { get; set; }
                
    }
}