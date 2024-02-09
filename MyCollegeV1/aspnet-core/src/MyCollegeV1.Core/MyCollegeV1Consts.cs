using MyCollegeV1.Debugging;

namespace MyCollegeV1
{
    public class MyCollegeV1Consts
    {
        public const string LocalizationSourceName = "MyCollegeV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2a6eadcf800b49adbdd315829bd9a32b";
    }
}
