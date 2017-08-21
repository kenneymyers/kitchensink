#Kitchen Sink
This is a simple project that is meant to showcase the features of Xamarin Forms.  Ideally, you should be able to create almost any type of basic application with the code in this repo.  It includes features like:

* How to interact with a SQlite database
* How to call a RESTful web service
* Every standard Xamarin.Forms control
* Every page type
* Every layout type
* How to store application settings
* It also includes a DevExpress Grid fed from SQLite

Everything should largely work with a fresh install of Visual Studio Community Edition 2017 (including Xamarin).  It should work equally well on MAC or PC.  It should run fine on Android and/or iOS.

##DevExpress Setup

If you run into issues with the DevExpress setup please add the component like any other component to your Android and iOS projects.  All of the instructions for getting DevExpress installed will be there.  You do have to init DevExpress in AppDelegate.cs and MainActivity.cs by adding

```
DevExpress.Mobile.Forms.Init();
```
After your call to 

```
global::Xamarin.Forms.Forms.Init();
```

The only other tricky thing is making sure you manually add a reference to DevExpress.Mobile.Grid.v17.1.dll and DevExpress.Mobile.Core.v17.1.dll (which are installed in your components library when you install the components for each platform).

