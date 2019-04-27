﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public GameObject destination;

    public override void Interact()
    {
        base.Interact();
        isInteracting = !isInteracting;
        player.transform.position = new Vector2(destination.transform.position.x, destination.transform.position.y);
        Debug.Log("Teleporting...");
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.UpArrow))
            Interact();
    }
}