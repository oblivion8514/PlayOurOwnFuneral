using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartbutton : MonoBehaviour {
	public GameObject obj;
	public GameObject tarObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseEnter(){
		obj.SetActive (false);
		tarObj.SetActive (true);
	}
	void OnMouseExit(){
		obj.SetActive (true);
		tarObj.SetActive (false);
	}
	void OnMouseUp(){
		GameManager.resetplayerSetting ();
		SceneManager.LoadScene (1);
	}
}
