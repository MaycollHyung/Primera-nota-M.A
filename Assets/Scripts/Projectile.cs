using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   public float speed;
   public float TimeToDestroy = 3f; 
   public Transform aim;
   public GameObject gO; 
   public int daño = 1;

    private void Start()
    {
        Destroy(gO, TimeToDestroy);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gO);
    }
}
