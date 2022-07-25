using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetLatestPostInstagramWithUserName.InstagramCore
{
    public class InstaOperation
    {
        public async Task<InstaCurrentUser> GetUserAsync(IInstaApi api)
        {
            var currentUser = await api.GetCurrentUserAsync();
            return currentUser.Value;
        }

        public async Task<List<string>> GetLatestPsot(IInstaApi api, string username, int pageCount = 1)
        {
            //var userInfo = await api.UserProcessor.GetUserInfoByUsernameAsync(username);
            var userMedias = await api.UserProcessor.GetUserMediaAsync(username, pageCount > 0 ? PaginationParameters.MaxPagesToLoad(pageCount) : PaginationParameters.Empty);

            List<string> medilist = new List<string>();
            if (userMedias.Succeeded)
            {
                foreach (var media in userMedias.Value)
                {
                    medilist.Add($"https://www.instagram.com/p/{media.Code}");
                }
            }
            else
                medilist.Add("Error while Followed: " + userMedias.Info.Message);

            return medilist;
        }
    }
}
