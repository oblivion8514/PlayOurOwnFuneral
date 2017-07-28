using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSuonaGame : MonoBehaviour {
	public GameObject suonaGame;
	public GameObject gameGenerator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		print (living_4.living4);
		if (!living_4.living4) {
			suonaGame.SetActive (true);
			gameGenerator.GetComponent<living_4> ().generate ();
		}
	}
}
