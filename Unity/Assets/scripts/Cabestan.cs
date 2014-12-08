using UnityEngine;
using System.Collections;

public class Cabestan: MonoBehaviour
{
  	// engrenage associè au Cabestan
  	public Engrenage[] _engrenage;
	public Vector3 angle;
	public bool right = true;

  public Cabestan()
  {
    
  }

  public Cabestan(Engrenage[] engrenage)
  {
    _engrenage = engrenage;
  }

	public void Update(){
		tourner();
	}
  // faire tourner le cabestan, équivaut à faire tourner la travée
  public void tourner()
  {
		/*angle = transform.rotation.eulerAngles;
		if (right) {
			transform.Rotate (new Vector3 (0, 0, 1) * Time.deltaTime);
			if (angle.y >= 270+89)
				right = false;
		} else {
			transform.Rotate (new Vector3 (0, 0, -1) * Time.deltaTime);
			if (angle.y <= 270)
				right = true;
		}*/
		for (int i = 0; i <2; i++) {
			_engrenage[i].tourner (0.5f);
		}
  }
}