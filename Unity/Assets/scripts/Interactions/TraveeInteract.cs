using UnityEngine;
using System.Collections;

public class TraveeInteract : Interact {

	public void Update(){
		if (running) {
			enfant.onAction ();
			running = !running;
			}

	}
	
}
