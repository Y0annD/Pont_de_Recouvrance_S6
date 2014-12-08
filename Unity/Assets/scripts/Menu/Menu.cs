using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

	bool isQuit=false;
	//var menu: GameObject;
	public void OnMouseEnter(){
		//change text color
		renderer.material.color=Color.red;
	}
	
	public void OnMouseExit(){
		//change text color
		renderer.material.color=Color.black;
	}
	
	public void OnMouseUp(){
		//is this quit
		if (isQuit==true) {
			//quit the game
			Application.Quit();
		}
		else {
			//load level
			//Application.LoadLevel(1);
			var player = (Camera_rotate)FindObjectOfType(typeof(Camera_rotate));

			//menu.GetComponent("Camera_rotate")().fadein=true;
		}
	}
	
	public void Update(){
		//quit game if escape key is pressed
		if (Input.GetKey(KeyCode.Escape)) { Application.Quit();
		}
	}
}

