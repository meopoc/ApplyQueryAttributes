using System.Reflection;
using System.Runtime.CompilerServices;

namespace ApplyQueryAttributes.Helpers.General
{
    public static class Tracker
    {
        public static void TrackError(Exception ex,
#pragma warning disable IDE0060 // Remove unused parameter - resolveAmbiguity is needed to resolve ambiguity, even if it's not used
            bool? resolveAmbiguity = null,
#pragma warning restore IDE0060 // Remove unused parameter
            [CallerMemberName] string memberName = "UnknownMethod",
            [CallerFilePath] string? sourceFilePath = null,
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Dictionary<string, string>? additionalData = null;

            TrackError(ex, additionalData, memberName, sourceFilePath, sourceLineNumber);
        }

        public static void TrackError(Exception ex,
            string additionalData,
            [CallerMemberName] string memberName = "UnknownMethod",
            [CallerFilePath] string? sourceFilePath = null,
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Dictionary<string, string> additionalDataDictionary = new()
            {
                { "data", additionalData }
            };

            TrackError(ex, additionalDataDictionary, memberName, sourceFilePath, sourceLineNumber);
        }

        public static void TrackError(Exception ex,
            Dictionary<string, string>? additionalData,
            //bool? resolveAmbiguity = null,
            [CallerMemberName] string memberName = "UnknownMethod",
            [CallerFilePath] string? sourceFilePath = null,
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Dictionary<string, string> data = new()
            {
                { "source", $"{GetFileName(sourceFilePath)} {memberName} {sourceLineNumber}" }
            };

            if (additionalData != null)
            {
                foreach (var kvp in additionalData)
                {
                    data[kvp.Key] = kvp.Value;
                }
            }

            WriteLine(ex.Message, memberName, sourceFilePath, sourceLineNumber);

            //TODO: Crashes.TrackError(ex, data);
        }

        public static void WriteLine(string message = "",
            [CallerMemberName] string memberName = "UnknownMethod",
            [CallerFilePath] string? sourceFilePath = null,
            [CallerLineNumber] int sourceLineNumber = 0)
        {
#if !DEBUG
            var console = Preferences.Get("console", false);

            if (!console) return;
#endif
            string output = $"**** {AppInfo.PackageName} {GetFileName(sourceFilePath)} {memberName} {sourceLineNumber}";

            if (message != null) output += $": {message}";

            Console.WriteLine(output);
        }

        private static string GetFileName(string? filePath)
        {
            string fileName = "UnknownFile";

            try
            {
                if (filePath != null)
                {
                    // handle folder separators on different platforms
                    char separatorChar = (char?)typeof(Path).GetTypeInfo().GetDeclaredField("DirectorySeparatorChar")?.GetValue(null) ?? '/';
                    string normalizedFilePath = filePath.Replace('\\', separatorChar);
                    fileName = Path.GetFileName(normalizedFilePath);

                    // prepend ios/ or android/ for platform specific files
                    if (normalizedFilePath.Contains($"{separatorChar}ios{separatorChar}"))
                        fileName = "ios/" + fileName;
                    else if (normalizedFilePath.Contains($"{separatorChar}android{separatorChar}"))
                        fileName = "android/" + fileName;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"**** com.mis.core Error processing file path. Exception: {ex.Message}");
            }

            return fileName;
        }
    }
}
