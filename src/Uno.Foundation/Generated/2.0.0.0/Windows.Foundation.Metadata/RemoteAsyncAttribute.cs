#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteAsyncAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public RemoteAsyncAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.RemoteAsyncAttribute", "RemoteAsyncAttribute.RemoteAsyncAttribute()");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.RemoteAsyncAttribute.RemoteAsyncAttribute()
	}
}
