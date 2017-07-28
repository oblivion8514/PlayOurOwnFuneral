using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbutton : MonoBehaviour {
	public GameObject obj;
	public GameObject tarObj;
	public GameObject page1;
	public GameObject page2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter(){
		obj.SetActive (false);
		tarObj.SetActive (true);
	}
	void OnMouseExit(){
		obj.SetActive (true);
		tarObj.SetActive (false);
	}
	void OnMouseUp(){
		page1.SetActive (false);
		page2.SetActive (true);
	}
}
