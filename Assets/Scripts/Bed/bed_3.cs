using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bed_3 : MonoBehaviour {
	public static bool bed3;
	GameObject UI;
	public GameObject tarObj;
	public GameObject highlightObj;
	public Image progress;
	// Use this for initialization
	void Start () {
		bed3 = false;
		UI = GameObject.Find ("UImanager");
	}
	
	// Update is called once per frame
	void Update () {
		if (!bed3) {
			if (UI.GetComponent<UImanager> ().item [7].activeInHierarchy &&
				UI.GetComponent<UImanager> ().item [8].activeInHierarchy &&
				UI.GetComponent<UImanager> ().item [9].activeInHierarchy) {
				setbed3 ();
			}
		}
	}
	void setbed3(){
		UI.GetComponent<UImanager> ().item [7].SetActive (false);
		UI.GetComponent<UImanager> ().item [8].SetActive (false);
		UI.GetComponent<UImanager> ().item [9].SetActive (false);
		bed3 = true;
		highlightObj.GetComponent<ItemHighlight> ().highlight ();
		//tarObj.SetActive (true);
		tarObj.SetActiveRecursively (true);
		progress.fillAmount += 0.1f;
		progress.GetComponent<AudioSource> ().Play ();

	}
}
