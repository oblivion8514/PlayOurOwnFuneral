using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneRecord: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.GetComponent<AudioSource> ().isPlaying) {
			this.gameObject.SetActive (false);
			living_2.living2progress = 2;
		}
	}
}
