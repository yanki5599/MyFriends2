using MyFriends2.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFriends2.Models
{
    public class Image
    {

        public Image(VMImage image)
        {
            Id = image.Id;
            FriendId = image.FriendId;
            MyImage = image.imageBytes;
        }

        public Image() { }

        [Key]
        public int Id { get; set; }

        public int FriendId { get; set; }
        public Friend Friend  { get; set; }

        [Display(Name = "תמונה")]
        public byte[] MyImage { get; set; }

    }
}
