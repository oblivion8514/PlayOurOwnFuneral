using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyBG : MonoBehaviour {
	public GameObject startscene;
	public GameObject gamescene;
	public GameObject UImanager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setsoryBG(){
		this.gameObject.SetActive (true);
		//Invoke ("opengame",1f);
	}
	void OnMouseUp(){
		startscene.SetActive (false);
		UImanager.SetActive (true);
		UImanager.GetComponent<UImanager> ().starttimer ();
		gamescene.SetActive (true);
		//this.gameObject.SetActive (false);
	}
}
