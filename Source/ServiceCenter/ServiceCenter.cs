using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using ServiceCenter.ServiceCenterWS;
using OutSystems.RuntimeCommon.Security;

namespace ServiceCenter
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
    class ServiceCenter
    {

        private ServiceStudio sCenter = new ServiceCenterWS.ServiceStudio();

        private string UserName = "";
        private string Password = "";

        private static string EncryptPassword(string s)
        {
            return Cryptutils.Encrypt(s);
        }
    }
}
