using UnityEngine;

public class Simulation
{

  private bool _pause;


  private Camera _camera;
  private Panneau _panneau;
  private Travee _travee;

  /* Constructeur, instancie tous les objets dont il à besoin*/
  public Simulation()
  {
    _pause = true;
    
    _camera    = new Camera();
    _panneau = new Panneau();
    _travee     = new Travee(); 
  }
}