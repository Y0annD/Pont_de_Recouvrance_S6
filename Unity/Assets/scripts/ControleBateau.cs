using UnityEngine;
using System.Collections;

/**
 * @class: ControleBateau
 * @description: 	classe qui gére le controle d'un bateau par l'utilisateur,
 * 					l'utilisateur conduit ou sort du bateau en appuyant sur la touche Enter
 * 					l'utilisateur avance le bateau via la touche Z ou touche fléchée Haut
 * 					l'utilisateur recule le bateau via la touche S ou touche fléchée Bas
 * 					l'utilisateur tourne le bateau vers la droite via la touche D ou touche fléchée droite
 *					l'utilisateur tourne le bateau vers la gauche via la touche Q ou touche fléchée gauche
 * 					la vitesse maximum du bateau est réglée par la variable vitesse_max
 **/

public class ControleBateau : MonoBehaviour {
	/*Controleurs du joueur*/
	CharacterController controleur;
	CharacterMotor moteur;
	/*Données sur le joueur et son emplacement*/
	GameObject joueur;
	public Transform emplacement_joueur;
	// vitesse max du bateau
	public int vitesse_max;
	bool estConduit = false;

	// position initiale en Y du bateau
	private float debutY;

	/**
	 * @function: Start
	 * @description: initialise les variables à l'entrée du script 
	 **/
	void Start () {
		// hauteur de départ du bateau pour l'effet de vagues
		debutY = gameObject.transform.position.y;
		/* Récupération des controleurs */
		controleur = GameObject.FindObjectOfType<CharacterController> ();
		moteur = GameObject.FindObjectOfType<CharacterMotor> ();
		joueur = moteur.gameObject;
		// emplacement du joueur
		emplacement_joueur = joueur.transform;

	}


	/**
	 * @function: estProcheDuBateau
	 * @description: Renvoie si l'utilisateur est proche du bateau ou non
	 * 				si sa sitance est inférieure à 4, le joueur est proche du bateau
	 * @return: true si d<3, false sinon
	 **/
	private bool estProcheDuBateau(){
		return Vector3.Distance(gameObject.transform.position, joueur.transform.position)<4;
		}

	/**
	 * @function: setConduit
	 * @description: 	Fonction qui change l'état de estConduit du véhicule,
	 * 					Si l'utilisateur se met à conduire le véhicule, on le met comme fils du véhicule
	 * 					et on désactive ses controleurs
	 * 					sinon on réactive les controleurs et on met le joueur à sa place
	 * @params: conduit: le joueur conduit-il le bateau?
	 **/
	private void setConduit(bool conduit){
		// on change l'état de estConduit
		estConduit = conduit;

		// on inverse l'état des controleurs
		controleur.enabled = !conduit;
		moteur.enabled     = !conduit;
		joueur.GetComponentInChildren<HeadBobbler> ().enabled = !estConduit;

		// si le véhicule est conduit, on place le joueur comme fils du véhicule
		// sinon comme fils de ce qu'il était avant
		if (estConduit)
			joueur.transform.parent = gameObject.transform;
		else
			joueur.transform.parent = emplacement_joueur;
		}

	/**
	 * @function: Update
	 * @description: mis à jour à chaque image
	 * 
	 **/ 
	void Update () {
		// si le joueur appuie sur la touche entrée, est est proche du bateau, on inverse son etat
		if (Input.GetKeyDown (KeyCode.Return) && estProcheDuBateau ())
				setConduit(!estConduit);
		// on met les forces à 0, pour ne pas en appliquer d'autres
		float propulsionAvant = 0;
		float propulsionLaterale = 0;

		/**
		 * Gestion des instructions de l'utilisateur 
		 **/
		if (estConduit) {
			// si il veut aller vers l'avant
			if(Input.GetKey (KeyCode.Z))
				propulsionAvant = 3;
			// si il veut ralentir ou faire marche arrière
			if(Input.GetKey (KeyCode.S))
				propulsionAvant = -1;

			// on ajoute les forces au bateau
			rigidbody.AddForce(gameObject.transform.right * propulsionAvant);

			// gestion de la rotation
			if(Input.GetKey (KeyCode.Q))
				propulsionLaterale = -1;
			if(Input.GetKey (KeyCode.D))
				propulsionLaterale = +1;

			//ajout du couple de rotation
			rigidbody.AddRelativeTorque(Vector3.up*propulsionLaterale);
		}

		// on  limite la vitesse du bateau
		rigidbody.velocity = Vector3.ClampMagnitude (rigidbody.velocity, vitesse_max);

		// calcul de la nouvelle hauteur du bateau pour la gestion des vagues
		Vector3 nouvellePosition = gameObject.transform.position;
		nouvellePosition.y = debutY + Mathf.Sin (Time.timeSinceLevelLoad * 2) / 10;
		gameObject.transform.position = nouvellePosition;
	}
}
