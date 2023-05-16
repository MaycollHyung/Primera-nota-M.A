using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int hp = 3;
    public GameObject Nave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "proyectil Enemigo")
            hp --;
        {
            hp -= collision.gameObject.GetComponent<ProyectilTorreta>().daño;
                if (hp <= 0)
                {
                    Destroy(Nave);
                }
        }
        
    }
}
