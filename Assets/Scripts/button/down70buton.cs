using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down70buton : MonoBehaviour {
	public static bool down70buttonclicked;
	public GameObject obj;
	public GameObject tarObj;

	public GameObject u70obj;
	public GameObject u70tarObj;

	public GameObject mainpage;
	public GameObject storyscene;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseEnter(){
		if (!down70buttonclicked) {
			obj.SetActive (false);
			tarObj.SetActive (true);
		}
	}
	void OnMouseExit(){
		if (!down70buttonclicked) {
			obj.SetActive (true);
			tarObj.SetActive (false);
		}
	}
	void OnMouseUp(){
		GameManager.age = 1;
		down70buttonclicked = true;
		up70button.up70buttonclicked = false;
		obj.SetActive (false);
		tarObj.SetActive (true);
		u70obj.SetActive (true);
		u70tarObj.SetActive (false);
		if (GameManager.gender != 0) {
			mainpage.SetActive (false);
			storyscene.GetComponent<storyBG> ().setsoryBG ();
		}
	}
}
