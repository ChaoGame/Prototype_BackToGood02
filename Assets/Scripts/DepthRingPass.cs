using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class DepthRingPass : MonoBehaviour {
	
	public Material mat;
	public Material matt;

	private bool isIn = true;
	
	void Start () {
		GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
	}
	
	void Update (){
		if (Input.GetKeyDown(KeyCode.E))
		{
			//set _StartingTime to current time
			mat.SetFloat("_StartingTime", Time.time);
			//set _RunRingPass to 1 to start the ring
			mat.SetFloat("_RunRingPass", 1);
			isIn = true;
		}
		if (Input.GetKeyUp (KeyCode.E)) 
		{
			//set _StartingTime to current time
			matt.SetFloat("_StartingTime", Time.time);
			//set _RunRingPass to 1 to start the ring
			matt.SetFloat("_RunRingPass", 1);
			isIn = false;
		}

	}
	
	// Called by the camera to apply the image effect
	void OnRenderImage (RenderTexture source, RenderTexture destination){
		//mat is the material containing your shader
		Graphics.Blit(source,destination,mat);

		if (isIn) {
			Graphics.Blit (source, destination, mat);
		} else {
			Graphics.Blit(source, destination, matt);
		}

	}
}