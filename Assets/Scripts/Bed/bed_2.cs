using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bed_2 : MonoBehaviour {
	public GameObject windowWithoutSmoke;
	public static bool bed2;
	public Image progress;
	// Use this for initialization
	void Start () {
		bed2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		print ("bed2 complete");
		this.gameObject.SetActive (false);
		windowWithoutSmoke.gameObject.SetActive (true);
		bed2 = true;
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();
	}
}
