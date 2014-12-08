using UnityEngine;

public class Roue : MonoBehaviour
{
  	// vitesse de rotation de la roue
  	public float _rot_vitesse;
  	// diamètre de la roue
  	public float _nbDents;
	public Vector3 rotAxis;

  /* constructeur
   * Le diamètre de la roue ne peut être modifiè après sa création
   **/
  public Roue(int dents)
  {
    _nbDents = dents;
    _rot_vitesse = 0.0f;
  }

  
  public float getDents(){return _nbDents; }
  public float getVitesse(){return _rot_vitesse;}

  public void setVitesse(float vitesse){ _rot_vitesse = vitesse; }

  /* Tourner
   * Permet de faire tourner la roue en fonction de celle qui la mène
   * @param Roue menante: roue qui mène cette roue
   **/
  public void tourner(Roue menante)
  {
		float vitesse = -(menante.getDents () / _nbDents) * menante.getVitesse ();
		setVitesse (vitesse);
		transform.Rotate (_rot_vitesse * rotAxis);
  }
}