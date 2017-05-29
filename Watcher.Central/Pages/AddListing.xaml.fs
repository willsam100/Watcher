namespace Watcher.Central.Pages

open Xamarin.Forms
open Xamarin.Forms.Xaml

type AddListing() = 
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<AddListing>)
