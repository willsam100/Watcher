namespace Watcher.Central.Pages

open Xamarin.Forms
open Xamarin.Forms.Xaml
open MvvmCross.Forms.Core

type FirstPage() = 
    inherit MvxContentPage()
    let _ = base.LoadFromXaml(typeof<FirstPage>)
