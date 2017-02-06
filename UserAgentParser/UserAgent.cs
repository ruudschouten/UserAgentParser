using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAgentParser {
    public class UserAgent {
        public string Source { get; set; }
        public string MozillaVersion { get; set; }
        public string System { get; private set; }
        public string SystemVersion { get; private set; }
        public string SystemDetailed { get; private set; }
        public string Platform { get; set; }
        public string BrowserPlatform { get; set; }
        public string Enhancements { get; set; }

        public UserAgent() { }

        public UserAgent(string source, string mozilla, string system, string systemVersion, string systemDetailed, string platform, string browserPlatform, string enhancements) {
            Source = source;
            MozillaVersion = mozilla;
            System = system;
            SystemVersion = systemVersion;
            SystemDetailed = systemDetailed;
            Platform = platform;
            BrowserPlatform = browserPlatform;
            Enhancements = enhancements;
        }

        public string ToDetailedString() {
            return $"Mozilla: {MozillaVersion}\nOS: {System} \nVersion: {SystemVersion} \nDetails: {SystemDetailed} \nPlatform: {Platform}\nBrowser Platform: {BrowserPlatform}\nEnhancements: {Enhancements}\n";
        }

        public override string ToString() {
            return $"OS: {System} \nVersion: {SystemVersion} \nDetails: {SystemDetailed} \nPlatform: {Platform}\n";
        }
    }
}
