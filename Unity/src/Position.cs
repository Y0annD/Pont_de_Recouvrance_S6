class Position{

  /*Attributs*/
  // position
  private double _x;
  private double _y;
  private double _z;
  // angle
  private double _ax;
  private double _ay;
  private double _az;

  /*
   * Constructeur par défaut de la position, tout est position è à 0
   */
  public Position()
  {
    _x   = 0;
    _y   = 0;
    _z   = 0;
    _ax = 0;
    _ay = 0;
    _az = 0;
  }

  /**
   * Constructeur de position, tous les éléments doivent être spécifiés
   * @param double x: position en x
   * @param double y: position en y
   * @param double z: position en z
   * @param double ax: orientation selon l'axe x
   * @param double ay: orientation selon l'axe y
   * @param double az: orientation selon l'axe z
   **/
  public Position(double x, double y, double z, double ax, double ay, double ay, double az)
  {
    _x   = x;
    _y   = y;
    _z   = z;
    _ax = ax;
    _ay = ay;
    _az = az;
  }


  // mutateurs de position
  /**
   * translater, permet d'effectuer une translation sur un objet
   * @param double x: décallage en x à effectuer
   * @param double y: décallage en y à effectuer
   * @param double z: décallage en z à effectuer
   **/
  public void translater(double x, double y, double z)
  {
    _x += x;
    _y += y;
    _z += z;
  }

  /**
   * rotater, permet d'effectuer une rotation sur un objet
   * @param double ax: rotation selon  x à effectuer
   * @param double ay: rotation selon y à effectuer
   * @param double az: rotation selon z à effectuer
   **/
  public void rotater(double ax, double ay, double az)
  {
    _ax += ax;
    _ay += ay;
    _az += az;
  }

  // accesseurs de position
  public double getX(){return _x; }
  public double getY(){return _y; }
  public double getZ(){return _z; }

  // accesseurs d'angle
  public double getAX(){return _ax; }
  public double getAY(){return _ay; }
  public double getAZ(){return _az; }
  
}