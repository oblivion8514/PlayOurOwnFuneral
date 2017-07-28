using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed1_detection : MonoBehaviour {
	public GameObject catalog;
	public GameObject catalogBig;
	public GameObject tarObj;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseUp(){
		if (catalog.GetComponent<bed_1>().isWillOpen) {
			catalog.GetComponent<bed_1> ().setbed1 ();
			catalogBig.SetActive (false);
			tarObj.SetActive (true);
		}
	}
}
