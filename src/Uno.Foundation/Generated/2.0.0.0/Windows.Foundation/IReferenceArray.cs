#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IReferenceArray<T> : global::Windows.Foundation.IPropertyValue
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		T[] Value
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Foundation.IReferenceArray<T>.Value.get
	}
}
