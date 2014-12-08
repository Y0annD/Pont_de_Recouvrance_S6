using UnityEngine;
using System.Collections;

public class Engrenage : MonoBehaviour
{
  	// liste des roues associées au système
  	public Roue[] _roues;

	public void Start(){

	}

	public void Update(){
	}

  	public Engrenage()
  	{
    
  	}

  	public Engrenage(Roue[] roues)
  	{
   	 _roues = roues;
  	}

 	 public void addRoue(Roue r)
  	{
		_roues.SetValue (r, _roues.Length);
  	}

  	public void addRoueAt(Roue r, int index)
  	{
		_roues.SetValue (r, index);
  	}

  	// fait tourner le système
  	public void tourner(float vitesse_initiale)
  	{
	_roues [0].setVitesse (vitesse_initiale);
	_roues [0].tourner (_roues [0]);
	for (int i = 1; i<_roues.Length; i++) {
		_roues[i].tourner(_roues[i-1]);
	}
  }

	public Quaternion getRotation(int index){
		return _roues [index].transform.localRotation;
		}


  
}