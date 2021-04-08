using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //User bilgileri geldiğinde CreateToken çalışacak ve veritabanına gidip bu kullanıcının claim'lerini
        //bulucak bu bilgilerle JWT üretecek 
 
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
