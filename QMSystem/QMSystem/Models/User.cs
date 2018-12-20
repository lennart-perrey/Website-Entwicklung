using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace QMSystem.Models
{
    public class User
    {
        public  bool checkPermission(string _Username, string _AuthGroup)
        {
            string[] tUsername = FullName(_Username);
            string tGroupUsers = string.Concat(GroupUsers(_AuthGroup));

            if (tGroupUsers.Contains(tUsername[0].ToString()))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Ermitteln der berechtigten Benutzer einer Gruppe als ArrayList
        /// </summary>
        /// <param name="groupName">AD-Group Name (Bsp: SFL_SFLCAM_D_G)</param>
        /// <returns>Alle berechtigten User</returns>
        private string[] GroupUsers(string _AuthGroup)
        {
            SearchResult tSearchResult;

            DirectorySearcher tDirectorySearcher = new DirectorySearcher();
            tDirectorySearcher.Filter = String.Format("(cn={0})", _AuthGroup);
            tDirectorySearcher.PropertiesToLoad.Add("member");

            tSearchResult = tDirectorySearcher.FindOne();

            List<string> tUsernames = new List<string>();
            if (tSearchResult != null)
            {
                for (int counter = 0; counter < tSearchResult.Properties["member"].Count; counter++)
                {
                    string tUser = (string)tSearchResult.Properties["member"][counter];
                    tUsernames.Add(tUser);
                }
            }
            return tUsernames.ToArray();
        }


        /// <summary>
        /// Ermitteln des vollständigen Usernames eines Benutzers.
        /// Beispiel:
        /// Short:  banzal
        /// Long:   Banzer Alessandro
        /// </summary>
        /// <param name="userName">Windows Short User Name (6 Charakters, Bsp: banzal)</param>
        /// <returns>Windows Long User Name (Bsp. Alessandro Banzer)</returns>
        private string[] FullName(string _Username)
        {
            SearchResult tResult;
            DirectorySearcher tDirectorySearcher = new DirectorySearcher();
            tDirectorySearcher.Filter = String.Format("(SAMAccountName={0})", _Username);
            tDirectorySearcher.PropertiesToLoad.Add("cn");

            tResult = tDirectorySearcher.FindOne();

            List<string> tUsernames = new List<string>();
            if (tResult != null)
            {
                for (int counter = 0; counter < tResult.Properties["cn"].Count; counter++)
                {
                    string tUser = (string)tResult.Properties["cn"][counter];
                    tUsernames.Add(tUser);
                }
            }
            return tUsernames.ToArray();
        }
    }
}
