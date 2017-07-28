using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class endscene : MonoBehaviour {
	public Image progress;
	public Text scoretext;
	// Use this for initialization
	void Start () {
		progress.fillAmount = GameManager.score / 10f;
		scoretext.text= GameManager.score + " / 10";
		if (GameManager.score > 5) {
			this.transform.GetChild (1).gameObject.SetActive (true);
		} else {
			this.transform.GetChild (0).gameObject.SetActive (true);
		}
		Invoke ("openbutton", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void openbutton(){
		this.transform.GetChild (2).gameObject.SetActive (true);
	}
}
