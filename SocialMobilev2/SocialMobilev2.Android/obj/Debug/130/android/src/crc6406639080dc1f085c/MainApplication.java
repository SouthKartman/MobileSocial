package crc6406639080dc1f085c;


public class MainApplication
	extends crc643f46942d9dd1fff9.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SocialMobilev2.MainApplication, SocialMobilev2.Android", MainApplication.class, __md_methods);
	}


	public MainApplication ()
	{
		super ();
		if (getClass () == MainApplication.class) {
			mono.android.TypeManager.Activate ("SocialMobilev2.MainApplication, SocialMobilev2.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public MainApplication (int p0)
	{
		super (p0);
		if (getClass () == MainApplication.class) {
			mono.android.TypeManager.Activate ("SocialMobilev2.MainApplication, SocialMobilev2.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
