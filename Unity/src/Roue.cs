class Roue
{
  // vitesse de rotation de la roue
  private float _rot_vitesse;
  // diam�tre de la roue
  private float _diametre;

  /* constructeur
   * Le diam�tre de la roue ne peut �tre modifi� apr�s sa cr�ation
   **/
  public Roue(float diametre)
  {
    _diametre = diametre;
    _rot_vitesse = 0.0f;
  }

  
  public void getDiametre(){return _diametre; }
  public void getVitesse(){return _rot_vitesse;}

  public void setVitesse(float vitesse){ _rot_vitesse = vitesse; }

  /* Tourner
   * Permet de faire tourner la roue en fonction de celle qui la m�ne
   * @param Roue menante: roue qui m�ne cette roue
   **/
  public void tourner(Roue menante)
  {
    
  }
}