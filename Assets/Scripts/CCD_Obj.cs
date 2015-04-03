using UnityEngine;
using System.Collections;

//This is the root of all things interactable objects in the game
//This allows for easy binding of subclass components

public abstract class CCD_Obj : MonoBehaviour {

    //This is the root click handler and handles when an object is right clicked
    //It does not work in the root class
    public abstract void OnReceiveClick();
    public abstract void OnReceiveInteract();

}
