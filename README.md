# Maui.RevenueCat.iOS
- this binding is based on: https://github.com/thisisthekap/Xamarin.RevenueCat.iOS 
- it is created for .NET MAUI and targeted to `.NET 7`
- it contains bindings for RevenueCat iOS plugin
	- https://www.revenuecat.com/
	- https://docs.revenuecat.com/docs/ios

## Versioning Scheme
The versioning scheme of `Maui.RevenueCat.iOS` is derived from the versioning of `revenuecat/purchases-ios`.

### Example:
| revenuecat/purchases-ios | Xamarin.RevenueCat.iOS | Note |
|:--|:--|:--|
| 3.4.1 | 3.4.1.0 | First version of bindings for 3.4.1 |
| 3.4.1 | 3.4.1.17 | Bindings for 3.4.1 containing fixes |

# Binding creation

## Porting old xamarin library ios to .NET MAUI
First version of our Maui binding was just changed `Xamarin.RevenueCat.iOS` binding working for .NET MAUI. It was binding around `RevenueCat ios 4.9.0`, but this native library contained bitcode which is no longer accepted by AppStore.
Porting of binding from Xamarin to Maui required several changes:
- Removed some attributes in `ApiDefinitions` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/5796f045bf6d8c591f8c5bc2afbb9535abd97bda)
- Changed `IntPtr` -> `NativeReference` in `ApiDefinitions` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/2adb01ce19f4423588cd1b87a290067fc25c3593)
	- [reference](https://blog.ostebaronen.dk/2023/04/net6.0-migration.html#6-change-intptr-to-nativehandle-on-ios)
- Added `NoBindingEmbedding = false` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/d88e24a8c4f36f1774c42801b482f8276d286b53)
## Creating completely new binding consisted of these steps:
Because of a problem with bitcode I have decided to create completely new binding from scratch. Here are steps I have done:
- On my MAC I have downloaded and installed [Objective Sharpie](https://learn.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/)
- I have downloaded [RevenueCat purchases-ios v4.19.0](https://github.com/RevenueCat/purchases-ios/releases/tag/4.19.0)
- I have extracted the `iOS` folder on my MAC desktop
- started terminal, then `cd ~/Desktop`
- I used command `sharpie bind -framework iOS/RevenueCat.framework -sdk iphoneos16.4 -scope iOS/RevenueCat.framework/Headers`
  - this command generated `ApiDefinitions.cs` and `StructsAndEnums.cs` files
- then I placed new framework file into repo
  - framework file - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/f03da2c2a98c0ae5cae5492a9f9974191aa880d8)
  - generated files - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/761d75b3fe01309a54fde1c5a1382d357e2b11d2)
- firstly commented but later completely removed `Verify` attributes - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/471e867dccf15124e81bcd9d1943f6599563629f)
- then removed all device-specific attributes - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/5aa004565614ba65d19ef3d96724e015f1584b44)
- added namespaces - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/09b545fc5f0f9bf2da8e328aa3b9757d7ed1f3c5)
- comment out text that was not commented out - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/bd79684d44e15f46cdd5225678e7bc52bfc746da)
- then I merged interfaces with the same names e.g. `RCAttribution` and `RCAttribution_RevenueCat_Swift_3714` I put together - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/43c996de81c8270b9783eadeea09ed557d6f8901)
  - I have also removed obsolete interfaces/methods 
- removed default using there were useless - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/459fc5d4bf09a4dfaaa6122c841a307f54779915)
- removed constants interface - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/f794248fa9a524e83471526b5517d9f1046b8f04)
  - because I didnt know how to bind `byte[]` 😅
- removed interfaces without methods/properties - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/221c593836f6e5dd956466cafe7603585b73b932)
- remove Protocols that were used for inheritance - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/b614289e0dbc4edefb4c6c7e024ae1586a6ebf83)
- removed delegate that was not used anywhere - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/d408d99423226391f7b37f73791bad7fc4772326)
- added `INativeObject` inheritance for interfaces that were used in dictionaries and was of type `NSObject` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/ea45d9555946887aa814fb470af45f616c89785d)
- replaced `NSUrlRequest` for `NSMutableUrlRequest` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/df1bb5ef23fa7176f3cc4f2b6a4778dea7baa53b)
- created delegates for Purchases - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/464d0e3028fea089bdb133bc8575381087f9d294)
- removed inherited `NSObject` methods - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/5fd366f5eb58903b1788a3781a9f6d00a470f681)
  - also removed `DebugDescription` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/d3741f1ce23b4b46e1a0184b03baafd1ff715201)
- removed inherited `NSOperation` methods - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/1033aaca86e60519ea4b75ed3fe6d65ea3e456c4)
- I have created aliases for methods named the same - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/866a0fbbff26b942307c77dd54bd14ac81de572b)
  - ⚠️ I dont know if this is correct or even necessary, maybe I could delete them as well
- removed attributes containing `Name` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/4aa727562d17829c742dcd6c2f51ba3c3cb836ff)
  - this was because on my windows machine I was getting errors that platform doesnt have symbols specified for this methods containing the name
  - later I completely removed those methods because the error was still there - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/3fcceeb6ff9d8207a3545f89ddf28639cb3c0f79)
- ✅ - Done 
  - I have tested this new binding in the simulator as well as on real device through TestFlight and it works as expected


## ⚠️**Warning**
- in .NET 7 and with VS2022 IT IS NOT POSSIBLE TO BUILD THE PACKAGE WITH EMBEDDED NATIVE LIBRARY (even with connected MAC).
- You need to build this package on MAC with VS for MAC. Only that way it will link native library to the package.
- https://github.com/dotnet/maui/issues/14982


# License
This repository is licensed with the [MIT](LICENSE.txt) license.
