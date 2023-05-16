using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilAmetralladora : MonoBehaviour
{
    public float speed = 8f;
    public GameObject proyectilametralladora;
    public float TimeToDestroy = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(proyectilametralladora, TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(proyectilametralladora);
    }
}
