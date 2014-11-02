class Camera{
  /* Vue de la caméra
   * true: vue libre
   * false: vue première personne
   **/
  private boolean _vue_libre;

  //position de la camèra 1ere personne
  private Position _position;

  // constructeur de la caméra
  public Camera()
  {
    _position = new Position();
    _vue_libre = false;
  }


  // permet de switcher entre la vue libre et la vue 1ere personne
  public void changer_vue()
  {
    _vue_libre = !_vue_libre;
  }
}