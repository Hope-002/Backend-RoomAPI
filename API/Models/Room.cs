using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Room
    {
        [Required]
        public int RoomId { get; set; }
        [Required]
        public string RoomName { get; set; }
        [Required]
        public String RoomType { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public String Gender { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Offers { get; set; }
        [Required]
        public string Ratings { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
       
    }

}


