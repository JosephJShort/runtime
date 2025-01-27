// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------
namespace System.Net.WebSockets
{
    public sealed partial class ClientWebSocket : System.Net.WebSockets.WebSocket
    {
        public ClientWebSocket() { }
        public override System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get { throw null; } }
        public override string? CloseStatusDescription { get { throw null; } }
        public System.Net.WebSockets.ClientWebSocketOptions Options { get { throw null; } }
        public override System.Net.WebSockets.WebSocketState State { get { throw null; } }
        public override string? SubProtocol { get { throw null; } }
        public override void Abort() { }
        public override System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string? statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string? statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Net.Http.HttpMessageInvoker? invoker, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Dispose() { }
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> ReceiveAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask SendAsync(System.ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class ClientWebSocketOptions
    {
        internal ClientWebSocketOptions() { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Net.CookieContainer? Cookies { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Net.ICredentials? Credentials { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Net.WebSockets.WebSocketDeflateOptions? DangerousDeflateOptions { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Net.IWebProxy? Proxy { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Net.Security.RemoteCertificateValidationCallback? RemoteCertificateValidationCallback { get { throw null; } set { } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public System.Version HttpVersion { get { throw null; } [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")] set { } }
        public System.Net.Http.HttpVersionPolicy HttpVersionPolicy { get { throw null; } [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")] set { } }
        public void AddSubProtocol(string subProtocol) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void SetBuffer(int receiveBufferSize, int sendBufferSize, System.ArraySegment<byte> buffer) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void SetRequestHeader(string headerName, string? headerValue) { }
    }
}
