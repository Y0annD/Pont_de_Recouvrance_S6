using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Vector3 angle;
	public bool right = true;
	

	// Update is called once per frame
	void Update () {
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
