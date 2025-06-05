public class Codec {
Dictionary<string, string> shortKey = new Dictionary<string, string>();
    int unique = 0;

    public string encode(string longUrl)
    {
        string shortUrl = "http://our-service.com/" + unique;
        unique++;
        
        shortKey.Add(shortUrl, longUrl);

        return shortUrl;
    }

    public string decode(string shortUrl)
    {
        return shortKey[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));