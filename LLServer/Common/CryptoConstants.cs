﻿using System.Text;

namespace LLServer.Common;

public static class CryptoConstants
{
    public  const string PRIVATE_KEY = @"-----BEGIN PRIVATE KEY-----
MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDLrefJsODZ3SXk
SblFOzHRAnhaG5PgPCvMkP9J08Ns6i1cTkGJXJx83Fx9dVJrvhK+pOHJCzgpqxnI
r81Yk3pfKLs1CCHbEphzd5WPxvwxKSHPljvrfV2xwtBFH2wOJN/b6NHy6Z3pT2in
9m5xo5TNoRzIdqWvJ55HAPyrua2UFxwv7l1JVVa49on86Hg6K+Tio26dgfKBD+LD
a8GA3d/q0HXKIqVR7RPnUVLXIlxq9aKWnYkDpcYSGHQ6YUlfrB/m8+72F5Ncaqeu
IKWKdeddXXNQ8NprS50PyfY5X02mGjOoPtNPikTrwbrlfP+IsBoS51KDt/VKG75U
W239wXg3AgMBAAECggEAEdSMXSvb+zvbXyk/C/r7Hkd06WUkTwslcG05vqjy9jFn
6Ck889KaK79kugzlEA6IeI0EQQPM66+RUcVmGLzMXSaP1jwl2UDpp04O1z0oWFYN
TNgOMHbTQXEC/NIb36nFuRbKw6pE4HxK9qKMQkF7kNFrrMw02T5YIkd0AcUpl17o
gc7gtH7n8aZgqMcrEFywmHM+zvKwReq5ldwKNAryTmodswDVsQEg5cWirytVnGvf
n7dmlzl2NZ/gM80Ta7G9SduWjZqnP+/B05C6yWYWwRVKVyncmhK4RGiewTW468fS
REM+Cw76RNBRY0pnlMQmg1o+m77z0lEGxFECR5iO3QKBgQDxCde3EV93y+0vqnCj
6PUdeAcFEQmON1uCsGz66oRn6Op0RWmOvhVtGa3m7xsL2c4Rvr6dIo3W2jta4i77
XK92wAe38WxdwgFU6fGs+vYvJTV1GDs1flDzdlNq3XGcNUYeIM2TnE/xe2KKtJJO
rBMyv6qQhUxdVpX6ORb3XAHJMwKBgQDYUmrfGBiJbdBwfAxIvYkqrYNNH60aG5D0
Cs02qFNANvMCCoiNxpPS98vupAR0MXMumvn4dPdbPDP4NnUydBCsl0rLNkN8dxuz
QMVrGQcDF/1cXBXSNFJdi0sbDB/P2ZxfTJvXUyg9XFclvMbV/nSNsC3z42oLLmg6
/f+X8cT87QKBgHFpZCoq7nR7axpmY6F71vkKpKLppUlZGqGfSWe2OJ57pPUYQ9Z5
8bLnxj9Geb9Vt/P5f86Hl51kCVF14w06SwTgzcDqw0ZKJj5B5Qiy/GqqY0C5KgK9
cHFdV1qM3wvUtS0v2gp+Hc9Ncsw4si56IH5cWHCvh4LTXrXhbsDsdZqpAoGBAJtX
/EU/UYeHY7MTceLesV0Dg5Hj2HQyLZMDGsFQeZBYpYPmuo9NdiR/LGSwRj6GsFdc
lXv1yxgqkIuD1/+mV78JWn259xavliXQsrSpIV74YEpuGoF8b1WbzRCcUU/6zo+l
PRiRMAl4gWCpQwSzmVGSnj1RJ3rmFZWfh2e/CB41AoGBAMKnczJq3cqd2Rzm6N+Q
0uZgVjN+GKEZX+KGZd535tPnZ9NqHxbYXcpu/XzbykRHwqmH9CbW0C/+JnOHqGT9
+qbmf/FcIAHHSA3HDXOyGM1lHUXUcPfGhPJ1GD3IBqNeNWjY0aSAYxR2pRX3Bb+4
AIlPFSOu7jYSw5+prAXZxmm7
-----END PRIVATE KEY-----";
    
    public const string PUBLIC_KEY = @"-----BEGIN PUBLIC KEY-----
MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAy63nybDg2d0l5Em5RTsx
0QJ4WhuT4DwrzJD/SdPDbOotXE5BiVycfNxcfXVSa74SvqThyQs4KasZyK/NWJN6
Xyi7NQgh2xKYc3eVj8b8MSkhz5Y7631dscLQRR9sDiTf2+jR8umd6U9op/ZucaOU
zaEcyHalryeeRwD8q7mtlBccL+5dSVVWuPaJ/Oh4Oivk4qNunYHygQ/iw2vBgN3f
6tB1yiKlUe0T51FS1yJcavWilp2JA6XGEhh0OmFJX6wf5vPu9heTXGqnriClinXn
XV1zUPDaa0udD8n2OV9NphozqD7TT4pE68G65Xz/iLAaEudSg7f1Shu+VFtt/cF4
NwIDAQAB
-----END PUBLIC KEY-----";

    public const string AES_KEY = "01234567890123456789012345678901";
    
    public static readonly byte[] AES_KEY_BYTES = Encoding.ASCII.GetBytes(AES_KEY[..16]);

    public const string IV = "0123456789012345";
    
    public static readonly byte[] IV_BYTES = Encoding.ASCII.GetBytes(IV);
}