#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Rfcomm
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RfcommDeviceServicesResult 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Bluetooth.BluetoothError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothError RfcommDeviceServicesResult.Error is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService> Services
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<RfcommDeviceService> RfcommDeviceServicesResult.Services is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceServicesResult.Error.get
		// Forced skipping of method Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceServicesResult.Services.get
	}
}
