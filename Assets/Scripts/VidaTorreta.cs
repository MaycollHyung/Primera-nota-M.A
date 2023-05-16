using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaTorreta : MonoBehaviour
{
    public int vidas = 15;
  
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Projectile")
        {
            vidas -= collision.gameObject.GetComponent<Projectile>().daño;
            if(vidas <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
