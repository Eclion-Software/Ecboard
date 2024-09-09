using Ecboard.Enums;

namespace Ecboard.ViewModels
{
    public class CardViewModel
    {
        public Enum_CardType CardType { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description { get; set; }
        public string? Footer { get; set; }
        public Enum_Color? Color { get; set; }
        public string? Image { get; set; }
        public string? Icon { get; set; }
        public string? Link { get; set; }
        public string? ButtonText { get; set; }
        public int? Progress { get; set; }
        public Enum_Direction Direction { get; set; }
    }
}
