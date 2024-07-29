using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Drawing;

namespace MyFriends2.ViewModels
{
    public class VMImage
    {
        public int Id { get; set; }
        public int FriendId { get; set; }

        [Display(Name = "תמונה")]
        public byte[] imageBytes { get; set; }

        [Display(Name = "הוספת תמונה")]
        public IFormFile? SetImage
        {
            get { return null; }
            set
            {
                if (value == null) return;
                MemoryStream stream = new MemoryStream();
                value.CopyTo(stream);
                imageBytes = stream.ToArray();
            }
        }

        public VMImage(Models.Image image)
        {
            Id = image.Id;
            FriendId = image.FriendId;
            imageBytes = image.MyImage;
        }

        public VMImage() { }

        public static implicit operator VMImage?(Models.Image? image)
        {
            return new VMImage(image);
        }
    }
}
