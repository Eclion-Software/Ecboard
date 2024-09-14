using Ecboard.Models.User;

namespace Ecboard.Helpers
{
    public static class EcUserHelper
    {
        public static User GetUser(string UserID)
        {
            return new User()
            {
                UserName = "Yusuf Okan Çevik"
            };
        }

        public static string CheckUserImage(string UserID)
        {
            if (String.IsNullOrEmpty(UserID))
            {
                return "/uploads/Defaults/DefaultUserPP.png";
            }            
            return "https://media.discordapp.net/attachments/1081536737135825028/1283869514231976120/image.png?ex=66e538e9&is=66e3e769&hm=93b6568fec1d9fd74af779b8af70d8903c3bd846eac5531e3ee773702498d014&=&format=webp&quality=lossless";
        }

        public static UserRole GetUserRole(string UserID)
        {
            return new UserRole()
            {
                Name = "Owner",
                Color = "#34fa2a"
            };
        }
    }
}
