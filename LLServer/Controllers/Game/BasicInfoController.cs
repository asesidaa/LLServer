using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using LLServer.Common;
using LLServer.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using XC.RSAUtil;

namespace LLServer.Controllers.Game;

[ApiController]
[Route("basicinfo")]
public class BasicInfoController : BaseController<BasicInfoController>
{
    [HttpPost]
    [Produces("application/octet-stream")]
    public ActionResult<byte[]> GetBasicInfo()
    {
        var info = new ResponseContainer
        {
            Result = 200,
            Response = new BasicInfo
            {
                BaseUrl = "http://127.0.0.1/game/info",
                DownloadUrl = "http://127.0.0.1/download",
                Key = CryptoConstants.AES_KEY,
                Iv = CryptoConstants.IV,
                TenpoIndex = 1337
            }
        };

        var jsonStr = JsonSerializer.Serialize(info);
        var privateKey = RsaKeyConvert.PrivateKeyPkcs8ToPkcs1(CryptoConstants.PRIVATE_KEY);
        var result = RsaEncryptWithPrivate(jsonStr, privateKey);
        
        return Ok(result);
    }
    
    private byte[] RsaEncryptWithPrivate(string clearText, string privateKey)
    {
        var bytesToEncrypt = Encoding.UTF8.GetBytes(clearText);

        var encryptEngine = new Pkcs1Encoding(new RsaEngine());

        using (var txtreader = new StringReader(privateKey))
        {
            var keyPair = (AsymmetricCipherKeyPair)new PemReader(txtreader).ReadObject();
            

            encryptEngine.Init(true, keyPair.Private);
        }
        
        return encryptEngine.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length);
    }
}