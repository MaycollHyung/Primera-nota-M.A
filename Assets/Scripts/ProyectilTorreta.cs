using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilTorreta : MonoBehaviour
{
    public float speed;
    public float TimeToDestroy = 3f;
    public GameObject Proyectil;
    public int daño = 1;

    //Necesario collider en cada objeto, uno necesita al menos un rigidbody para colisionar. 
    private void Start()
    {
        Destroy(Proyectil, TimeToDestroy);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(Proyectil);
    }
}
