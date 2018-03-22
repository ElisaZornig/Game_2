﻿using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 3f;

    bool isFocus = false;
    Transform player;

    public virtual void Interact() {
        //This method is meant to be overwritten
        Debug.Log("Interacting with" + transform.name);

    }




    void OnDrawGizmosSelected() {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
	
}
