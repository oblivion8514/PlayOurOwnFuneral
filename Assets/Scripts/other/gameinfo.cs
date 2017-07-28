using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameinfo : MonoBehaviour {
	public GameObject back;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setbackbutton(){
		Invoke ("backbutton",5f);
	}
	void backbutton(){
		back.SetActive (true);

	}
}
