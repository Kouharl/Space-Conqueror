using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour

{
    public int Escudo;

    public bool nave1 = true; //que nave esta funcionando actualmente. si es que siempre comenzamos con la nave 1
    public bool nave2; // Nave seleccionada o en juego actualmente.
    public float SpeedPlayer = 0.5f; //Velocidad del player
    public float XpeedPlayer = 1f; //Bonus turbo de velocidad
    public float OldSpeedPlayer;
    public string Escena; //Aqui se guardara el nombre de la Escena Actual.
    public bool DebugMapOn = false;
    public bool Escena1On = false;
    public int SaludH1; //salud nave 1
    public int SaludH2; //salud nave 2
    public int SaludH3; //salud nave 3
    public int ExperienciaH1;
    public int ExperienciaH2;
    public int ExperienciaH3;
    public bool InicioBlackHole;
    //Estadisticas de Balas
                        // TIPO 1
    public int AllyBulletType; // 0=Sin disparo, 1=bala tipo 1, 2=bala tipo 2.
    public float AllyBullet1Vida=2; //tiempo de vida del objeto instanciado
    public float AllyBullet1TasaDisparo = 0.5f;
    public float AllyBullet1Damage;
                        //TIPO 2
    public float AllyBullet2Vida = 0.3f; // despues de 0.1 se destruira el objeto bala tipo 2
    public float AllyBullet2TasaDisparo = 0.1f;
    public float AllyBullet2Damage;
                         //Sistema de Cambio
    public float TiempoRecargaCambio = 10f;




}
