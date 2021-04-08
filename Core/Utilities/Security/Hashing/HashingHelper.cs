using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {//verilern değerin hash'ini oluşturacak
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //passwordSalt: Kullanıcının girdiği parolayı güçlendirme.
                //out dışarıya döndürülecek default değer gibi birşey araştırılacak.
                //Her kullanıcı için farklı KEY oluşturur.
                passwordSalt = hmac.Key;
                //Gönderilen parolanın byte değerini almak.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            //password hash'ini doğrulama 
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
