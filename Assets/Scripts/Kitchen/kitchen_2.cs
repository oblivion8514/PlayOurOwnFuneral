using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kitchen_2 : MonoBehaviour {
	public GameObject[] lotus;
	public static bool kitchen2;
	public GameObject highlightObj;
	public GameObject targetObj;
	int flag;
	public Image progress;
	// Use this for initialization
	void Start () {
		kitchen2 = false;
		flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp(){
		if (!kitchen2) {
			lotus [flag].SetActive (false);
			lotus [++flag].SetActive (true);
			if (flag == 7) {
				setkitchen2 ();
			}
		}
	}
	void setkitchen2(){
		highlightObj.GetComponent<ItemHighlight> ().highlight ();
		targetObj.SetActive (true);
		kitchen2 = true;
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();
	}
}
