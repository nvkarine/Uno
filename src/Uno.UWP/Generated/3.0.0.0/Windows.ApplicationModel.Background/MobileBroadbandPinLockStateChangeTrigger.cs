#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandPinLockStateChangeTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MobileBroadbandPinLockStateChangeTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.MobileBroadbandPinLockStateChangeTrigger", "MobileBroadbandPinLockStateChangeTrigger.MobileBroadbandPinLockStateChangeTrigger()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Background.MobileBroadbandPinLockStateChangeTrigger.MobileBroadbandPinLockStateChangeTrigger()
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
