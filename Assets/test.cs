using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	//public AudioClip test1;
	//public AudioClip test2;
	// Use this for initialization
	void Start () {
		print ("test123");
		//AudioSource newaudio = this.gameObject.AddComponent<AudioSource> ();
		//newaudio.clip = test1;
		//this.GetComponent<AudioSource> ().clip = test1;
		//this.GetComponent<AudioSource> ().Play ();
		//this.GetComponent<AudioSource> ().loop = false;
		//Invoke ("settest2", 5f);
	}
	
	// Update is called once per frame
	void Update () {
		//print (this.GetComponent<AudioSource> ().isPlaying);
	}
	void settest2(){
		//this.GetComponent<AudioSource> ().clip = test2;
		//this.GetComponent<AudioSource> ().Play ();
	}
}
