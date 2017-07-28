using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelInfoButton : MonoBehaviour {
	public GameObject obj;
	public GameObject tarObj;
	public GameObject levelInfo;
	public GameObject end;
	public GameObject endUI;
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
		if (GameManager.score > 0) {
			obj.SetActive (true);
			tarObj.SetActive (false);
			end.SetActive (false);
			endUI.SetActive (false);
			levelInfo.SetActive (true);
			levelInfo.GetComponent<LevelInformation> ().openInform ();
		}
	}
}
