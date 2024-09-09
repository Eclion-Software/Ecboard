using Ecboard.Enums;

namespace Ecboard.ViewModels
{
    public class AlertViewModel
    {
        public string Name { get; set; } = "None";
        public string? Description { get; set; }
        public Enum_Color Color { get; set; }
        public Enum_AlertType AlertType { get; set; }
    }
}
