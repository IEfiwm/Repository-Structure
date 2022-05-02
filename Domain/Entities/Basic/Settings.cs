using Domain.Base.Entity;

namespace Domain.Entities.Basic
{
    public class Settings : IdentityBaseEntity
    {
        public Settings(string applicationName = "Rahbord.SMS.API")
        {
            ApplicationName = applicationName;
        }

        public string ApplicationName { get; private set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Data { get; set; }
    }
}