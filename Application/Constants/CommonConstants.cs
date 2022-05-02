using Microsoft.Extensions.Caching.Memory;
using System;

namespace Application.Constants
{
    public static class CommonConstants
    {
        public const string ApplicationName = "Rahbord.SMS";

        public const string ApplicationVersion = "V1.0";

        public const string FarapayamakUsernameKey = "FarapayamakUsername";

        public const string FarapayamakPasswordKey = "FarapayamakPassword";

        public static MemoryCacheEntryOptions MemoryCacheEntryOptions
        {
            get
            {
                return new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromHours(2));
            }
        }
    }
}