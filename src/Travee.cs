public class Travee
{
  // attributs
  private float _angle;
  private string _etat;
  private Machoire machoire;
  private Loquet loquet;
  private Cabestan cabestan;

  public Travee()
  {
    _angle = 0;
    _etat    = "fermé";

    // initialisation des systèmes
    machoire = new Machoire();
    loquet      = new Loquet();
    cabestan  = new Cabestan();
  }

  // faire tourner la travé
  public void tourner()
  {
    
  }

  // interragir avec le loquet
  public void interagir_loquet()
  {
    
  }

  // interragir avec la machoire
  public void interagir_machoire()
  {
    
  }
}

