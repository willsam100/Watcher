using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using Xamarin.Forms;
using System.IO;
using static Watcher.Central.Interfaces;
using MvvmCross.Platform;
using MvvmCross.Forms.Core;
using MvvmCross.Core.Views;
using MvvmCross.Forms.iOS.Presenters;

namespace Watcher.iOS
{
	public class Database : IDatabasePath
	{
		public string databasePath => 
			Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");

	}

	public class Setup : MvxIosSetup
	{
		public MvxFormsApplication MvxFormsApp { get; private set; }
		public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
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

			Mvx.RegisterSingleton<IDatabasePath>(new Database());
		}

		protected override IMvxIosViewPresenter CreatePresenter()
		{
			Forms.Init();

			MvxFormsApp = new Central.WatcherApplication();

			var presenter = new MvxFormsIosPagePresenter(Window, MvxFormsApp);
			Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

			return presenter;
		}
	}
}
