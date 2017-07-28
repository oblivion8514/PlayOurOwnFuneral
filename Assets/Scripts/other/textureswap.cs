using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureswap: MonoBehaviour {
	public GameObject obj;
	public GameObject targetObj;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseUp(){
		//print ("texture swap MouseUp");
		if (obj.activeInHierarchy) {
			obj.SetActive (false);
			targetObj.SetActive (true);
		}
		else if (targetObj.activeInHierarchy) {
			obj.SetActive (true);
			targetObj.SetActive (false);
		}
	}
}
