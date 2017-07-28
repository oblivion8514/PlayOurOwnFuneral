using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour {
	public GameObject mainpage;
	public GameObject info;
	public GameObject back;
	public GameObject back1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseUp(){
		back.SetActive (true);
		back1.SetActive (false);
		info.SetActive (false);
		mainpage.SetActive (true);
		//this.gameObject.SetActive (false);

	}
	void OnMouseEnter(){
		back.SetActive (false);
		back1.SetActive (true);
	}
	void OnMouseExit(){
		back.SetActive (true);
		back1.SetActive (false);
	}
}
