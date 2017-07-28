using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infobutton : MonoBehaviour {
	public GameObject info;
	//public GameObject mainpage;
	public GameObject obj;
	public GameObject tarObj;
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
		tarObj.SetActive (false);
		obj.SetActive (true);
		info.SetActive (true);
		//info.GetComponent<gameinfo> ().setbackbutton ();
		//mainpage.SetActive (false);
	}
}
