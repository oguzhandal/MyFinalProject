using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
