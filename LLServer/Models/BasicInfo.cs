using System.Text.Json.Serialization;

namespace LLServer.Models;

public class BasicInfo : ResponseBase
{
    /// <summary>
    /// This is the information url 
    /// </summary>
    [JsonPropertyName("base_url")] public required string BaseUrl { get; set; }

    [JsonPropertyName("download_url")] public required string DownloadUrl { get; set; }

    /// <summary>
    /// AES key, is used as a char* array, 32 bytes (characters)
    /// </summary>
    [JsonPropertyName("key")] public required string Key { get; set; }

    /// <summary>
    /// AES IV, 16 bytes (characters)
    /// </summary>
    [JsonPropertyName("iv")] public required string Iv { get; set; }

    [JsonPropertyName("tenpo_index")] public required int TenpoIndex { get; set; }
}