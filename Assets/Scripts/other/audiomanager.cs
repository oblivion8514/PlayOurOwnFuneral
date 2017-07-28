using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour {
	public GameObject[] audioObject;
	public static bool soundOn;//true:on false:off
	// Use this for initialization
	void Start () {
		soundOn = true;
		//print ("test1234");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (soundOn) {
			soundOn = false;
			for (int i = 0; i < audioObject.Length; i++) {
				audioObject [i].GetComponent<AudioSource> ().mute = true;
			}
			/*foreach (GameObject ao in audioObject) {
				ao.GetComponent<AudioSource> ().mute=true;
			}*/
		} else {
			soundOn = true;
			for (int i = 0; i < audioObject.Length; i++) {
				audioObject [i].GetComponent<AudioSource> ().mute = false;
			}
			/*foreach (GameObject ao in audioObject) {
				ao.GetComponent<AudioSource> ().mute = false;
			}*/
		}

	}
}
