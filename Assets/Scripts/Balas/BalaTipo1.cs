using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTipo1 : MonoBehaviour
{
    private Banco banco;
    private Rigidbody2D bulletRB;
    public float bulletSpeed;


    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        banco = GameObject.FindObjectOfType<Banco>();
        bulletRB.velocity = new Vector2(bulletRB.velocity.x, bulletSpeed);
    }


    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, banco.AllyBullet1Vida); // aqui le ordenamos morir a la bala en AllyBullet1Vida tiempo/
    }

    private void OnTriggerEnter2D(Collider2D ColisionBala)
    {
        if (ColisionBala.tag == "Enemigo")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Enemigo pierde salud!");
            Destroy(gameObject); //destruir objeto cuando entra en colision 
        }

    }
}
