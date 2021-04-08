using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductCountOfCategoryError = "Kategorideki maksimum ürün sayısını aştınız ";
        public static string ProductNanemAlreadyExists = "Bu isimde kayıtlı başka bir ürün var";
        public static string CategoryLimitExceded = "Bu kategori için maksimum ürün sayısına ulaşıldı.";
        public static string AuthorizationDenied="Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
