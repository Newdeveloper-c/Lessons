using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://text-translator2.p.rapidapi.com/translate"),
    Headers =
    {
        { "X-RapidAPI-Key", "ebd2daf35bmsh2b1dd1c8ca093fcp1df34cjsn104697508cd7" },
        { "X-RapidAPI-Host", "text-translator2.p.rapidapi.com" },
    },
    Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "source_language", "en" },
        { "target_language", "ru" },
        { "text", "hello, I often use chatgpt for my coding purposes. What about you?" },
    }),
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}