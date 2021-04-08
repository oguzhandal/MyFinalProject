using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        //Token anlamsız karakterlerden oluştuğu için string olarak tutuyoruz.
        //Expiration: Token geçerliliği bitiş tarihi
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
