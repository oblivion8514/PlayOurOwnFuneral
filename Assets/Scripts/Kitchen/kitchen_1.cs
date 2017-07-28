using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kitchen_1 : MonoBehaviour {
	public GameObject highlightObj;
	public GameObject targetObj;
	public GameObject hi_lightTable;
	public GameObject clock12;
	public static bool kitchen1;
	public Image progress;
	GameObject UI;
	// Use this for initialization
	void Start () {
		kitchen1 = false;
		UI = GameObject.Find ("UImanager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (!kitchen1) {
			if (UI.GetComponent<UImanager> ().item [4].GetComponent<ItemPreviewAndUse> ().used &&
				clock12.activeSelf) {
				UI.GetComponent<UImanager> ().item [4].SetActive (false);
				highlightObj.GetComponent<ItemHighlight> ().highlight ();
				hi_lightTable.SetActive (true);
				//targetObj.SetActive (true);
				setkitchen1 ();
			}
		}
	}
	void setkitchen1(){
		kitchen1 = true;
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();
	}
}
