using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class femalebutton : MonoBehaviour {
	public static bool femalebuttonclicked;

	public GameObject obj;
	public GameObject tarObj;

	public GameObject mobj;
	public GameObject mtarObj;

	public GameObject mainpage;
	public GameObject storyscene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter(){
		if (!femalebuttonclicked) {
			obj.SetActive (false);
			tarObj.SetActive (true);
		}
	}
	void OnMouseExit(){
		if (!femalebuttonclicked) {
			obj.SetActive (true);
			tarObj.SetActive (false);
		}
	}
	void OnMouseUp(){
		GameManager.gender = 2;
		femalebuttonclicked = true;
		malebutton.malebuttonclicked = false;
		obj.SetActive (false);
		tarObj.SetActive (true);
		mobj.SetActive (true);
		mtarObj.SetActive (false);
		if (GameManager.age != 0) {
			mainpage.SetActive (false);
			storyscene.GetComponent<storyBG> ().setsoryBG ();
		}
	}
}
