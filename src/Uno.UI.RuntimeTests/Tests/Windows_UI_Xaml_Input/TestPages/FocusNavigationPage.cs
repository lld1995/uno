﻿using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Input.TestPages
{
	public partial class FocusNavigationPage : Page
	{
		public FocusNavigationPage()
		{
			Loaded += Page_Loaded;
			Unloaded += Page_Unloaded;
		}

		public bool LoadedEventFinished { get; private set; }

		private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			LoadedEventFinished = true;
		}

		private void Page_Unloaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			LoadedEventFinished = false;
		}
	}
}
