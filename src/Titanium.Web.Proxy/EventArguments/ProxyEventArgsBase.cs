using System;
using Titanium.Web.Proxy.Network.Tcp;

namespace Titanium.Web.Proxy.EventArguments
{
    /// <summary>
    ///     The base event arguments
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public abstract partial class ProxyEventArgsBase : EventArgs
    {
        private TcpClientConnection clientConnection =>State.ClientConnection;

        public object ClientUserData
        {
            get => clientConnection.ClientUserData;
            set => clientConnection.ClientUserData = value;
        }

    }
}
