namespace UserAgentParser {
    public class Parser {
        private static string GetMozillaCompatibility(string userAgent) {
            return userAgent.Substring(0, userAgent.IndexOf("("));
        }
        private static string[] GetSystemDetails(string userAgent) {
            int start = userAgent.IndexOf("(");
            int end = userAgent.IndexOf(")");
            return userAgent.Substring(start, end - start).Split(';');
        }

        private static string GetBrowserPlatform(string userAgent) {
            int start = userAgent.IndexOf(")");
            int end = userAgent.LastIndexOf("(");
            return userAgent.Substring(start, end - start).Replace("(", "").Replace(")", "").Trim(' ');
        }
        private static string GetBrowserPlatformDetails(string userAgent) {
            int start = userAgent.LastIndexOf("(");
            int end = userAgent.LastIndexOf(")");
            return userAgent.Substring(start, end - start).Replace("(", "").Replace(")", "").Trim(' ');
        }

        private static string GetEnhancement(string userAgent) {
            int start = userAgent.LastIndexOf(")");
            return userAgent.Substring(start).Replace(")", "").Replace("(", "").Trim(' ');
        }

        public static UserAgent Parse(string userAgent) {
            string mozilla = GetMozillaCompatibility(userAgent);
            string[] systemDetails = GetSystemDetails(userAgent);
            string systemOs = systemDetails[0].TrimStart('(').Trim(' ');
            string systemVersion = systemDetails[1].Trim(' ');
            string systemDetailed = systemDetails[2].TrimEnd(')').Trim(' ');
            string browserPlatform = GetBrowserPlatform(userAgent);
            string browserPlatformDetails = GetBrowserPlatformDetails(userAgent);
            string enhancement = GetEnhancement(userAgent);
            return new UserAgent(userAgent, mozilla, systemOs, systemVersion, systemDetailed, browserPlatform, browserPlatformDetails, enhancement);
        }
    }
}
