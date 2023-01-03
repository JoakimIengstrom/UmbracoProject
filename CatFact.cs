namespace UmbracoProject.CatFact;

public class CatFact
{
    public string fact { get; set; }
    public int length { get; set; }
}

public class CatFactClient
{
    public static async Task<CatFact?> GetCatFactAsync()
    {
        var client = new HttpClient();
        var response = await client.GetFromJsonAsync<CatFact>("https://catfact.ninja/fact");

        return response;
    }
}