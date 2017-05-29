namespace Watcher.Central.Pages

open Xamarin.Forms
open Xamarin.Forms.Xaml

type ListingsPage() = 
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<ListingsPage>)
