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
	partial class MainPage : Microsoft.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var nameScope = new global::Microsoft.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			// Source ..\..\..\..\..\..\..\demo.Shared\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::Microsoft.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source ..\..\..\..\..\..\..\demo.Shared\MainPage.xaml (Line 11:6)
				Children = 
				{
					new global::Microsoft.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Text = "Hello, world!"/* string/, Hello, world!, TextBlock/Text */,
						Margin = new global::Microsoft.UI.Xaml.Thickness(20)/* Microsoft.UI.Xaml.Thickness/, 20, TextBlock/Margin */,
						FontSize = 30d/* double/, 30, TextBlock/FontSize */,
						// Source ..\..\..\..\..\..\..\demo.Shared\MainPage.xaml (Line 12:8)
					}
					.MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136_XamlApply((MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136XamlApplyExtensions.XamlApplyHandler0)(c0 => 
					{
						c0.CreationComplete();
					}
					))
					,
				}
			}
			.MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136_XamlApply((MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136XamlApplyExtensions.XamlApplyHandler1)(c1 => 
			{
				c1.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c2 => 
			{
				// Source Z:\UNO\UnoAzureDemo\demo\demo.Shared\MainPage.xaml (Line 1:2)
				
				// WARNING Property c2.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c3 => 
			{
				// Class demo.MainPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c3, global::Microsoft.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: false, context: global::demo.Wasm.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c3;
				c3.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Microsoft.UI.Xaml.Controls.Page _component_0
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Page)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::demo.MainPage Owner { get => (global::demo.MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::demo.MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(global::demo.MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace demo.Wasm
{
	static class MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Microsoft.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.TextBlock MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136_XamlApply(this global::Microsoft.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Microsoft.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.Grid MainPage_d5e6ce4bdeb04a3b0adf69a2e0daf136_XamlApply(this global::Microsoft.UI.Xaml.Controls.Grid instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
