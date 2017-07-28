using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPhoneRing : MonoBehaviour {
	public GameObject livingroom;
	public GameObject phoneRecord;
	// Use this for initialization
	void Start () {
		setInvokeRepeat ();
		//this.GetComponent<SpriteRenderer> ().color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.GetComponent<AudioSource> ().isPlaying) {
			this.GetComponent<SpriteRenderer> ().color = Color.clear;
		}
	}
	public void setInvokeRepeat(){
		InvokeRepeating ("setPhoneRing", 5f,24f);
	}
	public void setPhoneRing(){
		if (living_2.living2progress == 0) {
			if (livingroom.activeInHierarchy) {
				this.GetComponent<AudioSource> ().Play ();
				this.GetComponent<SpriteRenderer> ().color = Color.white;
				Invoke ("cancelPhoneRing", 8f);
			}
		}
	}
	void cancelPhoneRing(){
		this.GetComponent<AudioSource> ().Stop ();
	}
	void OnMouseUp(){
		if (this.GetComponent<AudioSource> ().isPlaying) {
			this.GetComponent<AudioSource> ().Stop ();
			this.GetComponent<SpriteRenderer> ().color = Color.clear;
			phoneRecord.SetActive (true);
			living_2.living2progress = 1;
		}
		if (living_2.living2progress == 2) {
			phoneRecord.SetActive (true);
			phoneRecord.GetComponent<AudioSource>().Play ();
		}
	}
}
