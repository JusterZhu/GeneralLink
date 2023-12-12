using GeneralLink.Kernel.Builder;
using GeneralLink.Kernel.Provider;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace GeneralLink.Kernel.Bluetooth
{
    internal class BluetoothClientProvider : ProviderAbstract<BluetoothClientProvider, BuildeParameter>
    {
        internal override BluetoothClientProvider GetResult()
        {
            return this;
        }

        internal override BluetoothClientProvider Launch()
        {
            BluetoothClient client = new BluetoothClient();
            BluetoothAddress address = BluetoothAddress.Parse("112233445566");
            BluetoothEndPoint ep = new BluetoothEndPoint(address, BluetoothService.SerialPort);
            client.Connect(ep);
            Stream stream = client.GetStream();
            stream.Write(new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 }, 0, 5);
            return this;
        }

        internal override Task<BluetoothClientProvider> LaunchTaskAsync()
        {
            throw new NotImplementedException();
        }

        internal override BluetoothClientProvider SetParameter(BuildeParameter parameter)
        {
            return this;
        }
    }
}
