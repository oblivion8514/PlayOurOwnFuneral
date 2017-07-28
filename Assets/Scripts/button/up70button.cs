using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up70button : MonoBehaviour {
	public static bool up70buttonclicked;
	public GameObject obj;
	public GameObject tarObj;

	public GameObject d70obj;
	public GameObject d70tarObj;

	public GameObject mainpage;
	public GameObject storyscene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter(){
		if (!up70buttonclicked) {
			obj.SetActive (false);
			tarObj.SetActive (true);
		}
	}
	void OnMouseExit(){
		if (!up70buttonclicked) {
			obj.SetActive (true);
			tarObj.SetActive (false);
		}
	}
	void OnMouseUp(){
		GameManager.age = 2;
		up70buttonclicked = true;
		down70buton.down70buttonclicked = false;
		obj.SetActive (false);
		tarObj.SetActive (true);
		d70obj.SetActive (true);
		d70tarObj.SetActive (false);
		if (GameManager.gender != 0) {
			mainpage.SetActive (false);
			storyscene.GetComponent<storyBG> ().setsoryBG ();
		}
	}
}
