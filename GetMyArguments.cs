private static Dictionary<string, string> GetMyArguments(string[] args)
{
   var regex = new Regex(@"(\s(-{1,2}|/)(?<key>\w+)([:=]?((['""](?<value>.*?)['""])|(?<value>\S+))?))");
   var matches = regex.Matches(Environment.CommandLine);
   return matches.Cast<Match>().ToDictionary(match => match.Groups["key"].Value, match => match.Groups["value"].Success ? match.Groups["value"].Value : null);
}
