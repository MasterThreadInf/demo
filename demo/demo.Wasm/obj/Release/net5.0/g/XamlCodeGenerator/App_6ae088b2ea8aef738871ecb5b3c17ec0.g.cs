// <autogenerated />
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
#pragma warning disable CS8669 // Ignore annotation for nullable reference types
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using demo.Wasm;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || NET461
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace demo
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("dotnet", "CA1001", Justification="Generated code")]
	partial class App : Microsoft.UI.Xaml.Application
	{
				private void InitializeComponent()
		{
			global::Windows.ApplicationModel.Resources.ResourceLoader.DefaultLanguage = "en-US";
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(GetType().Assembly);
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(typeof(global::Microsoft.UI.Xaml.FrameworkElement).Assembly);

			this
			.GenericApply((c0 => 
			{
				// Source Z:\UNO\UnoAzureDemo\demo\demo.Shared\App.xaml (Line 1:2)
				
				// WARNING Property c0.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Application, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			;

			global::demo.Wasm.GlobalStaticResources.Initialize();
			global::demo.Wasm.GlobalStaticResources.RegisterResourceDictionariesBySourceLocal();
			global::Uno.UI.DataBinding.BindableMetadata.Provider = new global::demo.Wasm.BindableMetadataProvider();
			#if __ANDROID__
			global::Uno.Helpers.DrawableHelper.Drawables = typeof(global::demo.Wasm.Resource.Drawable);
			#endif
			// Workaround for https://github.com/dotnet/runtime/issues/44269
			typeof(global::Uno.UI.Runtime.WebAssembly.HtmlElementAttribute).GetHashCode();
			// MergedDictionaries
			Resources.MergedDictionaries.Add(
			new global::Microsoft.UI.Xaml.Controls.XamlControlsResourcesV2()
			{
			}
			);
			// Source ..\..\..\..\..\..\..\demo.Shared\App.xaml (Line 1:2)
		}

	}
}
namespace demo.Wasm
{
	static class App_6ae088b2ea8aef738871ecb5b3c17ec0XamlApplyExtensions
	{
	}
}
