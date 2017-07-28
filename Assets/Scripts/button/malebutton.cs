using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malebutton : MonoBehaviour {
	public static bool malebuttonclicked;

	public GameObject obj;
	public GameObject tarObj;

	public GameObject fobj;
	public GameObject ftarObj;

	public GameObject mainpage;
	public GameObject storyscene;
	// Use this for initialization
	void Start () {
		malebuttonclicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter(){
		if (!malebuttonclicked) {
			obj.SetActive (false);
			tarObj.SetActive (true);
		}
	}
	void OnMouseExit(){
		if (!malebuttonclicked) {
			obj.SetActive (true);
			tarObj.SetActive (false);
		}
	}
	void OnMouseUp(){
		GameManager.gender = 1;
		malebuttonclicked = true;
		femalebutton.femalebuttonclicked = false;
		obj.SetActive (false);
		tarObj.SetActive (true);
		fobj.SetActive (true);
		ftarObj.SetActive (false);
		if (GameManager.age != 0) {
			mainpage.SetActive (false);
			storyscene.GetComponent<storyBG> ().setsoryBG ();
		}

	}
}
