using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour {
	public GameObject infopage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		infopage.SetActive (true);
		infopage.GetComponent<gameinfo> ().setbackbutton ();
	}
}
