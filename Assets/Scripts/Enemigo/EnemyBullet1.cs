using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet1 : MonoBehaviour {
    public EscudoPlayer escudoplayer;
    private Banco banco;
    private Rigidbody2D bulletRB;
    public float bulletSpeed=1;


    void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        escudoplayer = GameObject.FindObjectOfType<EscudoPlayer>();
        banco = GameObject.FindObjectOfType<Banco>();
        bulletRB.velocity = new Vector2((-bulletRB.velocity.x ), (-bulletSpeed));
    }

    void Update()
    {
        Destroy(gameObject, 3); // aqui le ordenamos morir a la bala en 3segundos tiempo/

    }
    private void OnTriggerEnter2D(Collider2D ColisionBala) {
        if (ColisionBala.tag == "Jugador")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("-1 DE ESCUDO");
            escudoplayer.ActualizacionEscudo(); // Funcion para ejecutar el dmg en el hud de escudo
            Destroy(gameObject,0.05f); //destruir objeto cuando entra en colision 

            if (banco.Escudo>0) { banco.Escudo--; }
        }

    }

}
