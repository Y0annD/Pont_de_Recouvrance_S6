#pragma strict

// Variable boleenne permettant de mettre de signifier l'état de la position du joueur face au panneau
private var etatPositionJoueur : boolean = false;

//texture de la page
var page : Texture;

// Si le joueur est près du panneau, l'étatPositionJoueur passe à 1
function OnTriggerStay (Col : Collider)
{
	if(Col.tag == "Player")
	{
		etatPositionJoueur = true;
	}
}

// Si le joueur sors de la boxe d'interaction du panneau, l'étatPositionJoueur passe à 0
function OnTriggerExit (Col : Collider)
{
	if(Col.tag == "Player")
	{
		etatPositionJoueur = false;
	}
}

// Si l'étatPositionJoueur est à 1, alors on affiche la page qui occupera une partie de l'écran
function OnGUI()
{
	if(etatPositionJoueur  == true)
	{
		GUI.DrawTexture(Rect(Screen.width / 20, Screen.height / 20, 420, 560), page);
	}
}