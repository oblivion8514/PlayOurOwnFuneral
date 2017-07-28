using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockswap : MonoBehaviour {
	public GameObject kitchen;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("swap", 3f, 15f);
		this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.activeSelf &&
		   !this.GetComponent<AudioSource> ().isPlaying) {
			this.GetComponent<AudioSource> ().Play ();
		}
	}
	void swap(){
		if (!this.gameObject.activeSelf) {
			this.gameObject.SetActive (true);
			if (kitchen.activeInHierarchy) {
				this.GetComponent<AudioSource> ().Play ();
			}
		} else {
			this.gameObject.SetActive (false);
		}
	}
}
