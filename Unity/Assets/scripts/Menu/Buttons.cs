using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{
	
	public bool touch = false;
	public int height = Screen.height;
	public float dx = Screen.width / 100.0f;
	public float dy = Screen.height / 100.0f;

	private void OnGUI(){
		height = Screen.height;
		dx = Screen.width / 100.0f;
		dy = Screen.height / 100.0f;
				if (!touch){
				if (GUI.Button (new Rect (2*dx, 90* dy, 15*dx, 7*dy), "Simuler")) {
						touch = true;
						GetComponentInParent<Camera_rotate> ().onFadeIn ();
				}
			if(!Application.isWebPlayer){
			if (GUI.Button (new Rect (4*dx+15*dx, 90*dy, 15*dx, 7*dy), "Quitter")) {
				Application.Quit();
			}
			}
		}
	}
}

