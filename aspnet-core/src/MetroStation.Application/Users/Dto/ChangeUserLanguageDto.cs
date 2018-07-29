using System.ComponentModel.DataAnnotations;

namespace MetroStation.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}