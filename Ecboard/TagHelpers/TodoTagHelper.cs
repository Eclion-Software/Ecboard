using Ecboard.Enums;
using Ecboard.ViewModels;
using Ecboard.ViewModels._PartialViews.TodoCard;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.VisualBasic;
using Mono.TextTemplating;
using System.Drawing;

namespace Ecboard.TagHelpers
{
    public class TodoTagHelper : TagHelper
    {
        private readonly IHtmlHelper _htmlHelper;

        public TodoTagHelper(IHtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string Title { get; set; }
        public string? Description { get; set; }
        public Enum_Color? TopBorder { get; set; } = Enum_Color.secondary;
        public string? Banner { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime EndDateTime { get; set; }
        public int LikeCount { get; set; }
        public List<TodoCommentViewModel>? Comments { get; set; }
        public List<TodoCheckListItemViewModel>? CheckList { get; set; }
        public List<string>? SharedUsers { get; set; }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware)?.Contextualize(ViewContext);

            var model = new TodoCardViewModel
            {
                Title = Title,
                Description = Description,
                Banner = Banner,
                TopBorder = TopBorder,
                CheckList = CheckList,  
                SharedUsers = SharedUsers,
                Comments = Comments,
                EndDateTime = EndDateTime,
                IsFavorite = IsFavorite,
                LikeCount = LikeCount
            };

            var partialViewHtml = await _htmlHelper.PartialAsync("~/Views/Shared/_PartialViews/_pTodoCard.cshtml", model);

            output.TagName = "card";
            output.Content.SetHtmlContent(partialViewHtml);
        }
    }
}
