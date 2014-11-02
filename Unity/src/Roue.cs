class Roue
{
  // vitesse de rotation de la roue
  private float _rot_vitesse;
  // diamètre de la roue
  private float _diametre;

  /* constructeur
   * Le diamètre de la roue ne peut être modifiè après sa création
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
   * Permet de faire tourner la roue en fonction de celle qui la mène
   * @param Roue menante: roue qui mène cette roue
   **/
  public void tourner(Roue menante)
  {
    
  }
}