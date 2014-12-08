using UnityEngine;
using System.Collections;

public class TraveeInteract : Interact {

	public Travee enfant;

	public void Update(){
		if (running) {
			enfant.onAction ();
			running = !running;
			}

	}
	
}
