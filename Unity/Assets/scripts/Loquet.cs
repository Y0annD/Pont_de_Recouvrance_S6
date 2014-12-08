using UnityEngine;

public class Loquet : Systeme
{
	public string ordre = "null";
	private float angle_verrouille = 339.4f;
	private float angle_deverrouille = 20.6f;
	public float angle;
	public GameObject moveObject;

	public void Update(){
		angle = moveObject.transform.eulerAngles.z;
		if (!pause) {
						if (ordre == "deverrouiller") {
								_engrenage.tourner (0.5f);
								if ((angle >= angle_deverrouille)&&(angle < angle_verrouille)) {
										ordre = "null";
										deverrouille = true;
								}
						} else if (ordre == "verrouiller") {
								_engrenage.tourner (-0.5f);
				if ((angle < angle_verrouille) && angle> angle_deverrouille) {
					ordre = "null";
										verrouille = true;
								}
						}
				}
	}

	// opération de verrouillage du système
	public void verrouiller()
	{
		ordre = "verrouiller";	
		deverrouille = false;
	}
	
	// opération de déverrouillage du système
	public void deverrouiller()
	{
		ordre = "deverrouiller";
		verrouille = false;
	}

	public void onAction(){
		if (deverrouille == false && verrouille == false) {
						pause = !pause;
				} else if (deverrouille == false) {
						deverrouiller ();
				} else {
						verrouiller ();
				}
	}
}