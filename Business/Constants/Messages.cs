﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renk listelendi";

        public static string CarAdded = "Araç eklendi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarListed = "Araç listelendi";
        public static string CarNameInValid = "Araç ismi geçersiz";
        public static string CarDailyPriceInValid = "Günlük fiyatı 0 dan büyük olmalıdır.";
        public static string MaintenanceTime = "Sistem bakımda";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcı listelendi";

        public static string CustomerAdded = "Müsteri eklendi";
        public static string CustomerUpdated = "Müsteri güncellendi";
        public static string CustomerDeleted = "Müsteri silindi";
        public static string CustomerListed = "Müsteri listelendi";

        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalReturnDateError = "Araç teslim edilmemiştir.";
        public static string RentalListed = "Kiralama Bilgileri Listelendi";
        
        public static string CarImageLimit = "En fazla 5 Araba resmi eklenebilir.";
        public static string CarImageAdded = "Araba Resmi Eklendi.";
        public static string CarImageNotFound = "Araba resmi bulunamadı";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Access Token Oluşturuldu";
    }
}
