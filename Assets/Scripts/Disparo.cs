using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject projectile;
    public Transform aim;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, aim.position, Quaternion.identity);
        }
    }
}
