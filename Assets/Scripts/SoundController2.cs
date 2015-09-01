using UnityEngine;
using System.Collections;

public class SoundController2 : MonoBehaviour {

	private bool playOrNot = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.E) && GetComponent<AudioSource> ().volume <= 1f) {
			//GetComponent<AudioSource> ().Play ();
			GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume + 0.1f;
			
		}
		
		
		if (Input.GetKeyDown (KeyCode.E)&& GetComponent<AudioSource> ().volume >= 0f) 
		{
			GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume - 0.1f;
			
		}
	
	}
}
