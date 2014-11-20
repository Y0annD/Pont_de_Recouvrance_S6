using UnityEngine;
using System.Collections;

public class Cabestan: MonoBehaviour
{
  	// engrenage associè au Cabestan
  	private Engrenage _engrenage;
	public Vector3 angle;
	public bool right = true;

  public Cabestan()
  {
    
  }

  public Cabestan(Engrenage engrenage)
  {
    _engrenage = engrenage;
  }

  // faire tourner le cabestan, équivaut à faire tourner la travée
  public void tourner()
  {
		angle = transform.rotation.eulerAngles;
		if (right) {
			transform.Rotate (new Vector3 (0, 0, 1) * Time.deltaTime);
			if (angle.y >= 270+89)
				right = false;
		} else {
			transform.Rotate (new Vector3 (0, 0, -1) * Time.deltaTime);
			if (angle.y <= 270)
				right = true;
		}
  }
}