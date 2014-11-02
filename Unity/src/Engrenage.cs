class Engrenage
{
  // liste des roues associées au système
  private List<Roue> _roues = new List<Roue>();

  public Engrenage()
  {
    
  }

  public Engrenage(List<Roue> roues)
  {
    _roues = roues;
  }

  public void addRoue(Roue r)
  {
    _roues.add(r);
  }

  public void addRoueAt(Roue r, int index)
  {
    _roues.insert(index, r);
  }

  // fait tourner le système
  public void tourner()
  {
    
  }
  
}