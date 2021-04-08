using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

//using Microsoft.IdentityModel.Tokens;  eklenmiyorsa Nuget den Microsoft.Identity.Token install et

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //Şifreleme sistemlerinde her şey byte[] formatında olmalı
        //asp.net JWT servislerinin anlayacağı hale getirme işlemi.
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
