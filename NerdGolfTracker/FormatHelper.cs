namespace NerdGolfTracker
{
    public class FormatHelper
    {
        public static string SchlagNomen(int schlaege)
        {
            return schlaege == 1 ? "Schlag" : "Schlaege";
        }
    }
}
