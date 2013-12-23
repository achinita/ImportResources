using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OutSystems.RuntimeCommon.Security;
using ServiceCenter_Connect.ServiceCenterWS;
using System.IO;

namespace ServiceCenter_Connect
{
        /* Reflection Encrypt
     * public static string Encrypt(string s)
     *  {
	 *       MD5CryptoServiceProvider mD5CryptoServiceProvider = null;
	 *       string result;
	 *       try
	 *       {
	 *	        mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
	 *	        s += "cdjnes3h4w";
	 *	        result = BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(new UnicodeEncoding().GetBytes(s))).Replace("-", null);
	 *       }
	 *       catch
	 *       {
	 *	        result = string.Empty;
	 *       }
	 *       finally
	 *       {
	 *	        if (mD5CryptoServiceProvider != null)
	 *	        {
	 *		        ((IDisposable)mD5CryptoServiceProvider).Dispose();
	 *	        }
	 *       }
	 *       return result;
     *   }
     */
    public class ServiceCenter
    {
        private string _ssUrl = @"http://{0}/ServiceCenter/ServiceStudio.asmx";

        private ServiceStudio ssConnect = new ServiceStudio();
        public ServiceStudio Connection
        {
            get { return ssConnect; }
        }
        private Login loginInfo = new Login();
        public Login LoginInfo
        {
            get { return loginInfo; }
        }

        public ServiceCenter()
        {
        }

        public string SelectEspace()
        {
            if (CheckAuth())
            {
                ListEspaces list = new ListEspaces(this);
                list.ShowDialog();

                if (list.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    string omlPath = 
                        Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" +
                        list.Selected_eSpace.Name +
                        ".oml";

                    File.WriteAllBytes(omlPath, list.Selected_eSpace.Data);
                    return omlPath;
                }
            }
            return null;
        }
        public bool tryLogin(string hostname, string username, string password, out string message) 
        {
            message = string.Empty;
            ssConnect.Url = String.Format(_ssUrl, hostname);
            try
            {
                ApplicationInfo[] apps = ssConnect.Apps_ListApplications(username, password, false);

                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;

                string errorMsg_comp = message.ToLower();
                if (errorMsg_comp.Contains("invalid login")) message = "Invalid Login";

                return false;
            }
            
        }
        public class Espace
        {
            private int id;
            public int Id
            {
                get { return id; }
            }
            private string name;
            public string Name
            {
                get { return name; }
            }

            public Espace(int eSpaceId, string eSpaceName)
            {
                id = eSpaceId; name = eSpaceName;
            }
        }
        public bool CheckAuth()
        {
            if (loginInfo.Hostname == null || loginInfo.Username == null || loginInfo.Password == null)
            {
                return loginInfo.LoginForm(this) == System.Windows.Forms.DialogResult.OK;
            }
            return true;
        }
    }
}
