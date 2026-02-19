using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace TimeTravelAgency.Services;

public class MistralService
{
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;

    public MistralService(IConfiguration config)
    {
        _config = config;
        _httpClient = new HttpClient();
    }

    public async Task<string> AskAsync(string userMessage)
    {
        var apiKey = _config["Mistral:ApiKey"];

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);

        var systemPrompt = """
Tu es l'assistant virtuel de TimeTravel Agency, une agence de voyage temporel de luxe.

Ton rôle : conseiller les clients sur les meilleures destinations temporelles.

Ton ton :
- Professionnel mais chaleureux
- Passionné d'histoire
- Enthousiaste sans être trop familier
- Crédible et expert

Tu connais parfaitement :
- Paris 1889 (Belle Époque, Tour Eiffel, Exposition Universelle)
- Crétacé -65M (dinosaures, nature préhistorique)
- Florence 1504 (Renaissance, Michel-Ange)

Tu peux recommander une destination selon les intérêts du client.

Prix indicatifs :
- Paris 1889 : 4 900€
- Florence 1504 : 5 200€
- Crétacé : 12 000€
""";

        var body = new
        {
            model = "mistral-small",
            messages = new[]
            {
                new { role = "system", content = systemPrompt },
                new { role = "user", content = userMessage }
            },
            temperature = 0.7
        };

        var content = new StringContent(
            JsonSerializer.Serialize(body),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync(
            "https://api.mistral.ai/v1/chat/completions",
            content);

        var json = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);
        return doc.RootElement
                  .GetProperty("choices")[0]
                  .GetProperty("message")
                  .GetProperty("content")
                  .GetString() ?? "";
    }
}
