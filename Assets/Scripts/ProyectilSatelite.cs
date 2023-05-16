using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilSatelite : MonoBehaviour
{
    public GameObject proyectilSatelite;
    public float TimeToDestroy = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(proyectilSatelite, TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(proyectilSatelite);
    }
}
