using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Models;


namespace DAL
{
   public  class AdminService
    {
       public string GetAdmins(string loginId, string loginPwd)
       {
           FileStream fs = new FileStream("loginInfo.txt", FileMode.Open);
           StreamReader sr = new StreamReader(fs);
           string info = sr.ReadLine();
           string[] Infoarry = info.Split('\t');
           Admins objadmins = new Admins()
           {
               LoginId = Infoarry[0].ToString(),
               LoginPwd = Infoarry[1].ToString(),
               AdminName = Infoarry[2].ToString()
           };
           sr.Close();
           fs.Close();
           if (loginId == objadmins.LoginId && loginPwd == objadmins.LoginPwd)
           {
               return objadmins.AdminName;
           }
           else
           {
               return string.Empty;
           }

       }
    }
}
