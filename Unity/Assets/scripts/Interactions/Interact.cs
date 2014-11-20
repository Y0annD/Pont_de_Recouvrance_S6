using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	public GUIText target;
	public bool running = false;
	//Enfant avec lequel intéragir
	public Travee enfant;
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
		/*renderer.material.color = Color.green;*/
		target.text = "Appuyez sur E pour intéragir";
		isLoocked = true;
	}

	public void onLookExit(){
		/*renderer.material.color = Color.white;*/
		target.text = "";
		isLoocked = false;
	}

	void OnGUI(){
		Event e = Event.current;
		if(e.isKey && e.character == 'e' && isLoocked){
			running = !running;
		}

	}
}
