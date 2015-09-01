using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour{
	
	public float FloatStrenght;
	public float RandomRotationStrenght;
	
	
	void Update () {
		transform.GetComponent<Rigidbody>().AddForce(Vector3.up *FloatStrenght);
		transform.Rotate(RandomRotationStrenght,RandomRotationStrenght,RandomRotationStrenght);
	}
	
}
