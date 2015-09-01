using UnityEngine;
using System.Collections;

public class playMusic : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<AudioSource> ().Play ();
			Debug.Log ("release");
		}



	}
}
