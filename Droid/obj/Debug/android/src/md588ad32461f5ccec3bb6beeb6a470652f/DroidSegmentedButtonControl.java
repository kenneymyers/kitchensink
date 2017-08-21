package md588ad32461f5ccec3bb6beeb6a470652f;


public class DroidSegmentedButtonControl
	extends android.widget.RadioGroup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFinishInflate:()V:GetOnFinishInflateHandler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v17.1, Version=17.1.2.0, Culture=neutral, PublicKeyToken=null", DroidSegmentedButtonControl.class, __md_methods);
	}


	public DroidSegmentedButtonControl (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == DroidSegmentedButtonControl.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v17.1, Version=17.1.2.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public DroidSegmentedButtonControl (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == DroidSegmentedButtonControl.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v17.1, Version=17.1.2.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void onFinishInflate ()
	{
		n_onFinishInflate ();
	}

	private native void n_onFinishInflate ();

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
