using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItem : MonoBehaviour {
	public GameObject targetObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (!UImanager.usingitem) {
			this.gameObject.SetActive (false);
			targetObj.SetActive (true);
		}
	}
}
