using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static olan class newlenmez 
    // public ddegişkenler BÜYÜK harf ile başlar
    public static class Messages
    {
        public static string CarAdded = "Araç  Eklendi";
        public static string CarDeleted = "Araç Silind";
        public static string CarUpdated = "Araç Güncelendi";
        public static string CarPriceIsInvalid = "Araç fiyatı Geçersiz";
        public static string CarsListed = " Araçlar Listelendi";
        public static string GetByCar = "Araç Bilgileri Listelendi";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string CarsListedByColor = "Araçlar Rengine göre listelendi";
        public static string ListCarsByBrand = "Araçlar Markasına göre listelendi";
        public static string CarDetails = "Araç detayları Listelendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = " Renk Silindi";
        public static string ColorUpdated = "Renk Güncelendi";
        public static string ColorListed = "Renkler Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDelete = "Marka Silind";
        public static string BrandUpdate = "Marka Güncellendi";
        public static string Brandlisted = "Markalar Listelendi";
        public static string BrandIsInvalid = "Marka İsmi geçersiz";
    }
}
