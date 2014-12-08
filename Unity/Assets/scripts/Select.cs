using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	public RaycastHit hit;
	private bool hitted = false;
	private RaycastHit lasthit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));

		if (Physics.Raycast (ray, out hit, 10)) {
			//Component comps[] = hit.collider.gameObject.GetComponents();

						if (hit.collider.gameObject.GetComponent<Interact> () != null) {
								hitted = true;
								lasthit = hit;
								hit.collider.gameObject.GetComponent<Interact> ().onLookEnter ();
						}
				} else if (hitted == true) {
			lasthit.collider.gameObject.GetComponent<Interact>().onLookExit();
			hitted = false;
				}

		           
	}
}
