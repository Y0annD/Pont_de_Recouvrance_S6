using UnityEngine;
using System.Collections;

public class Vue_libre : MonoBehaviour {

	// vitesse de déplacement
	private float vitesse = 0.5f;
	// vue libre activee
	public bool vue_libre;
	// Touche de descente
	private bool ctrl;
	// Touche pour monter
	private bool shift;
	// Accélérations
	private float acc = 3;
	private float accRatio  = 1;
	private float descente = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyDown (KeyCode.LeftShift))&& vue_libre==true ) {
			transform.position = transform.position + new Vector3(0,10,0);
				}

		if (Input.GetKeyUp (KeyCode.LeftShift) || Input.GetKeyUp (KeyCode.LeftShift)) {

		}


		if (Input.GetKeyDown(KeyCode.C))
			switchCamera();

	}


	public void switchCamera()
	{
		if (!vue_libre) //means it is currently disabled. code will enable the flycam. you can NOT use 'enabled' as boolean's name.
		{
			vue_libre = true;
		}
		else if (vue_libre) //if it is not disabled, it must be enabled. the function will disable the freefly camera this time.
		{
			vue_libre = false;
		}
	}

}
