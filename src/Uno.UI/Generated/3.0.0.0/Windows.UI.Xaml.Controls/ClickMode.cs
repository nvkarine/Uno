#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ClickMode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Release,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Press,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Hover,
		#endif
	}
	#endif
}
