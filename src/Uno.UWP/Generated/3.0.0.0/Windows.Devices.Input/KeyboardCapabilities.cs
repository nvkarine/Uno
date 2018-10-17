#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class KeyboardCapabilities 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int KeyboardPresent
		{
			get
			{
				throw new global::System.NotImplementedException("The member int KeyboardCapabilities.KeyboardPresent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public KeyboardCapabilities() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Input.KeyboardCapabilities", "KeyboardCapabilities.KeyboardCapabilities()");
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.KeyboardCapabilities.KeyboardCapabilities()
		// Forced skipping of method Windows.Devices.Input.KeyboardCapabilities.KeyboardPresent.get
	}
}
