using UnityEngine;
using System.Collections;

public class LoquetInteract : Interact {

	public Loquet enfant;
	
	public void Update(){
		if (running) {
			enfant.onAction ();
			running = !running;
		}
		
	}
}
