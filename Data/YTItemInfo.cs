using Google.GData.YouTube;
using Sitecore.Data;

namespace Sitecore.SharedSource.YoutubeIntegration.Data
{
   public class YTItemInfo
   {
      public string Name { get; private set; }
      public ID TemplateID { get; private set; }
      public ID ItemID { get; private set; }
      public YouTubeEntry YouTubeItem { get; private set; }

      #region constructor

      public YTItemInfo(ID itemID, ID templateID, string name, YouTubeEntry entry)
      {
         ItemID = itemID;
         TemplateID = templateID;
         Name = name;
         YouTubeItem = entry;
      }

      #endregion constructor
   }
}
