using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
    public GameObject EnemyBullet;
    public Transform EnemyCannon;
    public float SigDisparo;
    public float RateFire;

    private void Start() { RateFire = 1f; }

    void Update () {

        if(Time.time > SigDisparo)
        {
            Instantiate(EnemyBullet, EnemyCannon.position, EnemyCannon.rotation);
            SigDisparo = Time.time + RateFire;
        }
		
	}
}
