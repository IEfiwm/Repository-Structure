using Common.Helpers;
using System;

namespace Common.Constants
{
    public static partial class MainConstants
    {
        public const int DefaultPageSize = 20;

        public const string SystemUserId = "70a075af-7ada-47e2-b65d-dd545a20d8a4";

        public const string WebApiUsername = "apisystem";

        public const string WebApiPassword = "MyStructure@MyStructure@MyStructure@13@13@13!@#";

        public readonly static string DefaultKey = "MyStructure@!@#!@#X@sm&=c]uX!7auPZ";

        public readonly static string SettingKey = "MyStructure@!@#!@#98Sfx7P9TxmDzUch";

        public const int SmsCodeExpiryInMinutes = 2; //2 minutes

        public const int TokenExpiryInMinutes = 1 * 60 * 24 * 14; //2 days

        public const int AuthorizationCodeExpiryInMinutes = 1 * 60 * 24 * 14; //2 days

        public const int RefreshTokenExpiryInMinutes = 5; //5 minutes

        #region Ftp Folders

        public const string FtpImageFolder = "images";

        public const string FtpAvatarFolder = "Avatars";

        public const string FtpTravelerPhotosFolder = "TravelerPhotos";

        #endregion

        #region Cookies name

        public const string IsVisitorCookie = "IsVisitorCookie";

        public const string UserInformationCookie = "UserInformationCookie";

        #endregion

        #region Cache keys

        public const string DefaultCacheManager = "MemoryCacheManager";

        public const string MemoryCacheManagerKey = "memory_cache";

        public const string PerRequestCacheManagerKey = "perrequest_cache";

        public const string SettingCacheKey = "Setting";

        public const string TelegramSettingCacheKey = "TelegramSettingCacheKey";

        public const string UrlRecordsCacheKey = "UrlRecords";

        public const string ThemeEngineDataCacheKey = "ThemeEngineData";

        public const string LoginAttemptsCacheKey = "LoginAttempts";

        public const string ProjectCacheKey = "Projects";

        public const string TimeSheetCategoryCacheKey = "TimeSheetCategory";

        public const string ApplicationRoleCacheKey = "ApplicationRole";

        public const string PermisionListCacheKey = "PermisionList";

        public const string MenuConfigurationCacheKey = "MenuConfiguration";

        public const string TimeSheetProjectBoundaryConfigCacheKey = "TimeSheetProjectBoundaryConfig";

        public const string WorkingCalendarDayCacheKey = "WorkingCalendarDay";


        #endregion

        #region User Profiles

        public const string UserProfileActivities = "activities";

        public const string UserProfilePosts = "posts";

        public const string UserProfileComments = "comments";

        public const string UserProfileFavorites = "favorites";

        #endregion

        public static string DefaultAdminDevice => $"AdminBrowser_{Guid.NewGuid()}";

        public static string ApiUserId => "5b5028db-f305-49bd-9591-38e656c757c0"; //ToDo configurable from admin panel

        public const string ReadMoreTag = "<!--more-->";

        public const string ClaimUserInformation = "ClaimUserInformation";

        public const string ClaimUserNickName = "MyStructure.NickName";

        public const string ClaimUserFullName = "MyStructure.FullName";

        public const string ClaimUserDeviceType = "MyStructure.DeviceType";

        public const string ClaimUserDeviceNumber = "MyStructure.DeviceNumber";

        public const string ClaimUserDeviceSpecification = "MyStructure.DeviceSpecification";

        public const string ClaimUserAvatarPath = "MyStructure.AvatarPath";

        public const string ClaimUserUserType = "MyStructure.UserType";

        public const string ClaimUserIsProfileCompleted = "MyStructure.IsProfileCompleted";

        public const string ClaimUserRoles = "MyStructure.UserRoles";

        public const string ClaimNotificationCount = "MyStructure.NotificationCount";

        public const string LanguagesCacheKey = "LanguagesCacheKey";

        public static string DefaultCultureName = string.IsNullOrEmpty(CommonHelper.GetConfigurationSetting("DefaultLanguage")) ?
            "fa" : CommonHelper.GetConfigurationSetting("DefaultLanguage");

        public const string RouteTrackerAppSettingKey = "IsRouteTrackerEnabled";

        public const string ModuleCacheKey = "ModuleCache";

        public const string FilterItemCacheKey = "ModuleCache";

        public const string WwwAuthenticateKey = "WWW-Authenticate";

        public const string BasicAuthenticationKey = "Basic";

        public const string GoogleExternalProvider = "Google";

        public const string LinkedInExternalProvider = "LinkedIn";

        public static object MicrosoftExternalProvider = "Microsoft";

        public const string UserPostedPhoto = "UserPostedPhoto";

        public static string CreateLanguageCacheKey(string culture)
        {
            return $"Language_{culture}";
        }

    }
}
