using System;
using System.Net.Security;

namespace Net6API.Middleware
{
	public static class CipherSuites
	{
        internal static readonly CipherSuitesPolicy SelectedCipherSuitesPolicy = new
        (
            new TlsCipherSuite[]
            {
                TlsCipherSuite.TLS_AES_128_CCM_SHA256,
                TlsCipherSuite.TLS_AES_256_GCM_SHA384,
                TlsCipherSuite.TLS_AES_128_GCM_SHA256
            }
        );
    }
}

