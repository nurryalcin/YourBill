using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed="Ürünler listelendi.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CompanyAdded = "Firma Eklendi.";
        public static string CompanyListed="Firmalar listelendi.";
        public static string AdisyonAdded="Adisyon eklendi.";
        public static string ErrorMessage = "Hata Alındı.";



        public static string Multiple_Add_Message(string text) => $@"Multiple {text}s  Added";
        public static string Add_Message(string text) => $@" {text}  Added";
        public static string Update_Message(string text) => $@"Updated the {text}";
        public static string Delete_Message(string text) => $@"Deleted the {text}";

        public static Dictionary<Type, string> GetNameDict = new Dictionary<Type, string>
        {
            { typeof(Adisyon), "Adisyon"},
            { typeof(City)," City"},
            { typeof(Company),"Company"},
            { typeof(District),"District"},
           
        };

    }
}
