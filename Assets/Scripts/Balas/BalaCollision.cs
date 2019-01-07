﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaCollision : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D ColisionBala)
    {
        if (ColisionBala.tag == "Enemigos")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

        }

    }

}
