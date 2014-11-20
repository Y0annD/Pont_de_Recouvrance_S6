using UnityEngine;
using System.Collections;

public class Engrenage : MonoBehaviour
{
  // liste des roues associ�es au syst�me
  private ArrayList _roues = new ArrayList();

  public Engrenage()
  {
    
  }

  public Engrenage(ArrayList roues)
  {
    _roues = roues;
  }

  public void addRoue(Roue r)
  {
		_roues.Add (r);
  }

  public void addRoueAt(Roue r, int index)
  {
    _roues.Insert(index, r);
  }

  // fait tourner le syst�me
  public void tourner()
  {
    
  }
  
}