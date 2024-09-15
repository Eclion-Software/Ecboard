namespace Ecboard.ViewModels._PartialViews
{
    public class ContactCardViewModel
    {
        public string ContactID { get; set; } = "";
        public string? UserID { get; set; }
        public string FullName { get; set; } = "";
        public string? Image { get; set; }
        public string? UnitTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = "";
    }
}
