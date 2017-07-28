using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{
	/*void Start(){
		DontDestroyOnLoad (this);
	}*/
	public string link;

	public void OpenLink()
	{
		Application.OpenURL(link);
	}

	public void OpenLinkJS()
	{
		Application.ExternalEval("window.open('"+link+"');");
	}

	public void OpenLinkJSPlugin()
	{
		#if !UNITY_EDITOR
		openWindow(link);
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}