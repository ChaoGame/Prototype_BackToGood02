using UnityEngine;
using System.Collections;

public class HideController01 : MonoBehaviour {
	public GameObject speaker;
	public GameObject phonograph;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.E)) {
			speaker.SetActive(false);
			phonograph.SetActive(true);
		}

		if (Input.GetKeyUp (KeyCode.E)) {
			speaker.SetActive(true);
			phonograph.SetActive(false);
		}
	}
}
