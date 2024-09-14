using Ecboard.Enums;

namespace Ecboard.ViewModels._PartialViews.TodoCard
{
    public class TodoCardViewModel
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public Enum_Color? TopBorder { get; set; }
        public string? Banner { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime EndDateTime { get; set; }
        public int LikeCount { get; set; }
        public List<TodoCommentViewModel>? Comments { get; set; }
        public List<TodoCheckListItemViewModel>? CheckList { get; set; }
        public List<string>? SharedUsers { get; set; } //USERS ID'S

    }
}
