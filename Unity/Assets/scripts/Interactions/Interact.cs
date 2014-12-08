using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	public GUITexture gui;
	public bool running = false;
	//Enfant avec lequel intéragir

	private bool isLoocked = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	/*void Update () {
		/*if(running)
			transform.Rotate (new Vector3 (0, 0, 10) * Time.deltaTime);*/
	/*}*/

	public void onLookEnter(){
		renderer.material.color = Color.green;
		gui.enabled = true;
		isLoocked = true;
	}

	public void onLookExit(){
		/*renderer.material.color = Color.white;*/
		gui.enabled = false;
		isLoocked = false;
	}

	void OnGUI(){
		Event e = Event.current;
		if(e.isKey && e.character == 'e' && isLoocked){
			running = !running;
		}

	}
}
