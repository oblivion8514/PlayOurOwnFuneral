using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class living_2 : MonoBehaviour {
	public static int living2progress;
	//1:接起電話 2:電話聽完後 3:完成
	public static bool living2;

	public Image progress;

 	// Use this for initialization
	void Start () {
		living2progress = 0;
		living2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setliving2(){
		living2 = true;
		living2progress = 3;
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();
	}
}
