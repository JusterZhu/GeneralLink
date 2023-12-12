using GeneralLink.Kernel.Builder;
using GeneralLink.Kernel.Provider;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel.Bluetooth
{

    internal class BluetoothServerProvider : ProviderAbstract<BluetoothServerProvider, BuildeParameter>
    {
        internal override BluetoothServerProvider GetResult()
        {
            throw new NotImplementedException();
        }

        internal override BluetoothServerProvider Launch()
        {
            BluetoothListener listener = new BluetoothListener(BluetoothService.SerialPort);
            listener.Start();
            BluetoothClient client = listener.AcceptBluetoothClient();
            Stream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesReceived = stream.Read(buffer, 0, buffer.Length);
            return this;
        }

        internal override Task<BluetoothServerProvider> LaunchTaskAsync()
        {
            throw new NotImplementedException();
        }

        internal override BluetoothServerProvider SetParameter(BuildeParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}
