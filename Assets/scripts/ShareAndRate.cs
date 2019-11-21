using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;


public class ShareAndRate : MonoBehaviour {

	
	public void RateUs()
	{
		#if UNITY_ANDROID
		Application.OpenURL("market://details?id=YOUR_ID");
		#elif UNITY_IPHONE
		Application.OpenURL("itms-apps://itunes.apple.com/app/idYOUR_ID");
		#endif
	}

}
