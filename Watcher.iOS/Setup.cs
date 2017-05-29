using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using Xamarin.Forms;
using MvvmCross.Forms.Presenter.iOS;
using MvvmCross.Forms.Presenter.Core;
using System.IO;
using static Watcher.Central.Interfaces;
using MvvmCross.Platform;
using MvvmCross.Forms.Core;
using MvvmCross.Core.Views;

namespace Watcher.iOS
{
	public class Database : IDatabasePath
	{
		public string databasePath => 
			Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");

	}

	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
	            : base(applicationDelegate, window)
	    {
		}

		public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
	            : base(applicationDelegate, presenter)
	        {
		}

		protected override IMvxApplication CreateApp()
		{
			return new Central.MvvmApp();
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	
		protected override void InitializeFirstChance()
		{
			base.InitializeFirstChance();

			//Mvx.RegisterSingleton<IDatabasePath>(new Database());
		}
	}
}
