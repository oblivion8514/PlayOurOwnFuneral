using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kitchen_3 : MonoBehaviour {
	public GameObject[] message;
	GameObject UI;
	public Image progress;
	public static bool kitchen3;
	public GameObject targetObj;
	// Use this for initialization
	void Start () {
		kitchen3 = false;
		UI = GameObject.Find ("UImanager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (!message [0].activeInHierarchy&&!kitchen3) {
			message [0].SetActive (true);
			message [1].SetActive (true);
		}
		else if (message [1].activeSelf &&
		   UI.GetComponent<UImanager> ().item [5].GetComponent<ItemPreviewAndUse> ().used) {
			UI.GetComponent<UImanager> ().item [5].SetActive (false);
			message [1].SetActive (false);
			message [2].SetActive (true);
		}
		else if(message [1].activeSelf &&
			UI.GetComponent<UImanager> ().item [6].GetComponent<ItemPreviewAndUse> ().used) {
			UI.GetComponent<UImanager> ().item [6].SetActive (false);
			message [1].SetActive (false);
			message [3].SetActive (true);
		}
		else if (message [2].activeSelf &&
			UI.GetComponent<UImanager> ().item [6].GetComponent<ItemPreviewAndUse> ().used) {
			UI.GetComponent<UImanager> ().item [6].SetActive (false);
			message [2].SetActive (false);
			message [0].SetActive (true);
			setkitchen3 ();
		}
		else if (message [3].activeSelf &&
			UI.GetComponent<UImanager> ().item [5].GetComponent<ItemPreviewAndUse> ().used) {
			UI.GetComponent<UImanager> ().item [5].SetActive (false);
			message [3].SetActive (false);
			message [0].SetActive (true);
			setkitchen3 ();
		}
	}
	void setkitchen3(){
		print ("kitchen3 complete");
		kitchen3 = true;
		progress.fillAmount += 0.1f;
		this.gameObject.SetActive (false);
		targetObj.SetActive (true);
		progress.GetComponent<AudioSource> ().Play ();
	}
}
