using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bed_1 : MonoBehaviour {
	public GameObject willPreview;
	public bool isWillOpen;

	public static bool bed1;
	public Image progress;
	public GameObject catalogPreview;
	public GameObject tarObj;
	public GameObject goalObj;
	// Use this for initialization
	void Start () {
		bed1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isWillOpen && willPreview.activeInHierarchy) {
			//print ("detect");
			isWillOpen = true;
		}

	}
	void OnMouseUp(){
		catalogPreview.SetActive (true);
		if (!bed1) {
			tarObj.SetActive (true);
			goalObj.SetActive (false);
		} else {
			goalObj.SetActive (true);
			tarObj.SetActive (false);
		}
	}
	public void setbed1(){
		bed1 = true;
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();
	}
}
