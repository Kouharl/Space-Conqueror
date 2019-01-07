using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject ObjetoAseguir;
    public Vector2 PosicionMinimaCamara, PosicionMaximaCamara;
    public float smoothTime;
    private Vector2 velocity;
    void Start()
    {
        ObjetoAseguir = GameObject.Find("ControladorJugador");
    }
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x,
            ObjetoAseguir.transform.position.x,
            ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y,
            ObjetoAseguir.transform.position.y,
            ref velocity.y, smoothTime);

        transform.position = new Vector3(
        Mathf.Clamp(posX, PosicionMinimaCamara.x, PosicionMaximaCamara.x),
        Mathf.Clamp(posY, PosicionMinimaCamara.y, PosicionMaximaCamara.y),
        transform.position.z);
    }
}
