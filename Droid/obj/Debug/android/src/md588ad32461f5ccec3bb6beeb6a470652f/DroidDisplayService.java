package md588ad32461f5ccec3bb6beeb6a470652f;


public class DroidDisplayService
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.DroidDisplayService, DevExpress.Mobile.Grid.Android.v17.1, Version=17.1.2.0, Culture=neutral, PublicKeyToken=null", DroidDisplayService.class, __md_methods);
	}


	public DroidDisplayService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DroidDisplayService.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidDisplayService, DevExpress.Mobile.Grid.Android.v17.1, Version=17.1.2.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
