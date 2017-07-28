using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class living_1 : MonoBehaviour {
	public GameObject boy1;
	public GameObject boy2;
	public GameObject girl1;
	public GameObject girl2;
	public static bool living1;
	public Image progress;
	// Use this for initialization
	void Start () {
		living1 = false;
		this.GetComponent<AudioSource> ().loop = true;
		this.GetComponent<AudioSource> ().Play ();
		InvokeRepeating ("setliving1", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.GetComponent<AudioSource> ().isPlaying &&
		   this.gameObject.activeInHierarchy &&
		   !living1) {
			this.GetComponent<AudioSource> ().Play ();
		}
	}
	void setliving1(){
		if (!boy1.activeInHierarchy && boy2.activeInHierarchy && !girl1.activeInHierarchy && girl2.activeInHierarchy) {
			//print ("living1 complete");
			this.GetComponent<AudioSource>().Stop();
			living1 = true;
			progress.fillAmount += 0.1f;
			progress.GetComponent<AudioSource> ().Play ();
			CancelInvoke ();
		}
	}

}
