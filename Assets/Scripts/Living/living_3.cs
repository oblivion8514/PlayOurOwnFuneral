using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class living_3: MonoBehaviour {
	public static bool living3;
	GameObject UI;
	public GameObject highlightObj;//成功以後開黑幕
	public GameObject[] flowerObj;//highlight的花
	public GameObject[] targetObj;//背景上的花
	public GameObject[] itemObj;
	public Image progress;
	// Use this for initialization
	void Start () {
		living3 = false;
		UI = GameObject.Find ("UImanager");
		InvokeRepeating ("setliving3", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (GameManager.gender == 1 && GameManager.age == 1 &&
		   UI.GetComponent<UImanager> ().item [0].GetComponent<ItemPreviewAndUse> ().used) {
			print ("英年玉折");
			living3 = true;
			//highlight
			highlightObj.GetComponent<ItemHighlight> ().highlight ();
			flowerObj [0].SetActive (true);
			//
			//in real
			this.gameObject.SetActive (false);
			//targetObj [0].SetActive (true);
			itemObj [0].SetActive (false);
			//
		}
		if (GameManager.gender == 2 && GameManager.age == 1  &&
			UI.GetComponent<UImanager> ().item [1].GetComponent<ItemPreviewAndUse> ().used) {
			print ("妝台月冷");
			living3 = true;
			highlightObj.GetComponent<ItemHighlight> ().highlight ();
			flowerObj [1].SetActive (true);

			this.gameObject.SetActive (false);
			//targetObj [1].SetActive (true);
			itemObj [1].SetActive (false);
		}
		if (GameManager.gender == 2 && GameManager.age == 2 &&
			UI.GetComponent<UImanager> ().item [2].GetComponent<ItemPreviewAndUse> ().used) {
			print ("淑德常昭");
			living3 = true;
			highlightObj.GetComponent<ItemHighlight> ().highlight ();
			flowerObj [2].SetActive (true);

			this.gameObject.SetActive (false);
			//targetObj [2].SetActive (true);
			itemObj [2].SetActive (false);
		}
		if (/*GameManager.gender == 1 &&*/ GameManager.age == 2 &&
			UI.GetComponent<UImanager> ().item [3].GetComponent<ItemPreviewAndUse> ().used) {
			print ("福壽全歸");
			living3 = true;
			highlightObj.GetComponent<ItemHighlight> ().highlight ();
			flowerObj [3].SetActive (true);

			this.gameObject.SetActive (false);
			//targetObj [3].SetActive (true);
			itemObj [3].SetActive (false);
		}
	}
	void setliving3(){
		if (living3) {
			//print ("living3 complete");
			progress.fillAmount += 0.1f;
			progress.GetComponent<AudioSource> ().Play ();
			CancelInvoke ();
		}
	}
}
