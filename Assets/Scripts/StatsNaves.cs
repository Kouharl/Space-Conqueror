using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// AQUI CREAREMOS UNA FUNCION PARA SER LLAMADA CUANDO SE CAMBIE DE PERSONAJE Y ASI CARGAR STATS.
public class StatsNaves : MonoBehaviour {
    private Banco banco;

    void Start(){banco = GameObject.FindObjectOfType<Banco>();}

    public void CargarStatsNave()
    {
        if (banco.nave1==true)
        {
            Debug.Log("Stats nave1 cargados");
            banco.AllyBulletType = 2;
        }

        if (banco.nave2==true)
        {
            //Solo es una prueba del funcionamiento. Ya que realmente no debemos cambiar valores, 
            //solo leerlos para el funcionamiento de los huds
            Debug.Log("Stats Nave 2 Cargados");
            banco.AllyBulletType = 1;
            banco.AllyBullet2Damage = 2;
            //  banco.AllyBullet2Vida = 2;
            // banco.AllyBullet2TasaDisparo = 1;
               banco.SaludH2 = 4;
        }


   }
}

