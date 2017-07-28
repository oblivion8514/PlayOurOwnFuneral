﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSceneBackButton : MonoBehaviour {
	public GameObject obj;
	public GameObject tarObj;

	public GameObject levelInfo;
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
		obj.SetActive (true);
		tarObj.SetActive (false);
		levelInfo.GetComponent<LevelInformation> ().closeInform ();
	}
}
