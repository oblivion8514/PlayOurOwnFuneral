using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour {
	AsyncOperation ao;
	public Image progress;
	public Text loadtext;
	// Use this for initialization
	void Start () {
		startload ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void startload(){
		StartCoroutine(loadlevel());
	}
	IEnumerator loadlevel(){
		yield return new WaitForSeconds (1);

		ao = SceneManager.LoadSceneAsync (1);
		ao.allowSceneActivation = false;

		while (!ao.isDone) {
			loadtext.text=((int)(ao.progress*100)).ToString()+"%";
			progress.fillAmount = ao.progress;
			if (ao.progress == 0.9f) {
				loadtext.text="100%";
				progress.fillAmount = 1f;
				yield return new WaitForSeconds (1);
				/*loadtext.text = ("點擊左鍵以開始");
				if (Input.GetMouseButton (0)) {
					ao.allowSceneActivation = true;
				}*/
				ao.allowSceneActivation = true;
			}
			yield return null;
		}
	}

}
