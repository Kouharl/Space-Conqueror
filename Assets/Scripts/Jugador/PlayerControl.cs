using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Banco banco; //asignamos Stats como el puento para leer la script Banco
    public float test;   //sin usar


    void Awake()
    {
        banco = GameObject.FindObjectOfType<Banco>(); //Solicitamos leer inmediatamente la script Banco
        banco.OldSpeedPlayer = banco.SpeedPlayer;     // Guardamos nuestra velocidad actual en una variable segura.
                                                      // con esto aseguramos que se pueda volver al valor anterior.
    }

    // Update is called once per frame
    void Update()
    {
        // Stats = GameObject.FindObjectOfType<Banco>(); //Leemos constantemente los valores de script (Creo que asi funciona)
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            banco.SpeedPlayer = banco.XpeedPlayer; // Al apretar click derecho la velocidad aumentara al valor de XpeedPlayer
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                banco.SpeedPlayer = banco.OldSpeedPlayer; // Si dejamos de apretar, La velocidad regresara a su valor Antiguo
                                                          // guardada en la variable OldSpeedPlayer
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(banco.SpeedPlayer * 0.237f, 0, 0); //el valor 0.237f es para evitar velocidad 0.
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(banco.SpeedPlayer * -0.237f, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, banco.SpeedPlayer * 0.237f, 0);
            }
            else
            {
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0, banco.SpeedPlayer * -0.237f, 0);
                }
            }
        }
    }
    //public void PlayerShooting() {
    //    if (Input.GetButtonDown("Fire1") && banco.AllyBulletType == 1)
    //    {
    //        Instantiate(AllyBullets1, AllyCannonFire.position, AllyCannonFire.rotation);
    //        Debug.Log("DISPARANDO BALAS TIPO 1");
    //    }
    //    if (Input.GetButtonDown("Fire1") && banco.AllyBulletType == 2)
    //    {
    //        Instantiate(AllyBullets2, AllyCannonFire.position, AllyCannonFire.rotation);
    //        Debug.Log("DISPARANDO BALAS TIPO 2");
    //    }
    //}
}
