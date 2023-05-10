# Maui.RevenueCat.iOS
- this is a fork of: https://github.com/thisisthekap/Xamarin.RevenueCat.iOS with changes supporting `.NET MAUI` with `.NET 7`
- it contains bindings for RevenueCat iOS plugin
	- https://www.revenuecat.com/
	- https://docs.revenuecat.com/docs/ios

## Versioning Scheme
The versioning of our fork is derived from original bindings: `Xamarin.RevenueCat.iOS`. We specify original binding version and we add number representing fix in our implementation.

### Example:
Xamarin.RevenueCat.iOS | Maui.RevenueCat.iOS | Note |
|:--|:--|:--|
3.4.1.1 | 3.4.1.1-fix0 | Just forked version |
3.4.1.17 | 3.4.1.17-fix0 | Just forked version |
3.4.1.17 | 3.4.1.17-fix2 | 2 fixes in our implementation of iOS bindings |

# Porting this library to .NET MAUI
It required several changes
- Removed some attributes in `ApiDefinitions` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/5796f045bf6d8c591f8c5bc2afbb9535abd97bda)
- Changed `IntPtr` -> `NativeReference` in `ApiDefinitions` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/2adb01ce19f4423588cd1b87a290067fc25c3593)
	- [reference](https://blog.ostebaronen.dk/2023/04/net6.0-migration.html#6-change-intptr-to-nativehandle-on-ios)
- Added `NoBindingEmbedding = false` - [commit](https://github.com/Kebechet/Maui.RevenueCat.iOS/commit/d88e24a8c4f36f1774c42801b482f8276d286b53)

## ⚠️**Warning**
- in .NET 7 and with VS2022 IT IS NOT POSSIBLE TO BUILD THE PACKAGE WITH EMBEDDED NATIVE LIBRARY (even with connected MAC).
- You need to build this package on MAC with VS for MAC. Only that way it will link native library to the package.
- https://github.com/dotnet/maui/issues/14982


# License
This repository is licensed with the [MIT](LICENSE.txt) license.
