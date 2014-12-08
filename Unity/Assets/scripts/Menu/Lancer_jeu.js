var isQuit=false;
//var menu: GameObject;
function OnMouseEnter(){
//change text color
renderer.material.color=Color.red;
}

function OnMouseExit(){
//change text color
renderer.material.color=Color.black;
}

function OnMouseUp(){
//is this quit
if (isQuit==true) {
//quit the game
Application.Quit();
}
else {
//load level
//Application.LoadLevel(1);
//var player = (Camera_rotate)FindObjectOfType(typeof(Camera_rotate));
//player.fadein = true;
//menu.GetComponent("Camera_rotate")().fadein=true;
}
}

function Update(){
//quit game if escape key is pressed
if (Input.GetKey(KeyCode.Escape)) { Application.Quit();
}
}