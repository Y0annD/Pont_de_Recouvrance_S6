using UnityEngine;

public class Travee : MonoBehaviour
{
  	// attributs
  	public float _angle;
  	public string _etat;
  	public Machoire machoire;
  	public Loquet loquet;
  	public Cabestan cabestan;


	public Vector3 angle;
	private bool right = true;

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		if (_etat.Equals ("Mouvement")) {
			tourner ();
			}
	}


  public Travee()
  {
    _angle = 0;
    _etat    = "fermé";

    // initialisation des systèmes
    /*machoire = new Machoire();
    loquet    = new Loquet();
    cabestan  = new Cabestan();*/
  }

  // faire tourner la travé
  public void tourner()
  {

		angle = transform.localRotation.eulerAngles;
		if (right) {
			transform.Rotate (new Vector3 (0, 0, 1) * Time.deltaTime);
			if (angle.z >= 90){
				right = false;
				_etat = "fermé";
			}
		} else {
			transform.Rotate (new Vector3 (0, 0, -1) * Time.deltaTime);
			if (angle.z <= 0){
				right = true;
				_etat = "ouvert";
			}
		}
  }

  // interragir avec le loquet
  public void interagir_loquet()
  {
  }

  // interragir avec la machoire
  public void interagir_machoire()
  {
    
  }

	public void onAction(){
		if (!_etat.Equals ("Mouvement")) {
			_etat = "Mouvement";
				}else if(_etat.Equals("Mouvement")){
			_etat = "Pause";
		}
}
}

