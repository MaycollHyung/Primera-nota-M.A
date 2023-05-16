using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAmetralladora : MonoBehaviour
{
    public GameObject proyectilAmetralladora;
    public float Timer;
    public float TimeToSpawn;



    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= TimeToSpawn)
        {
            Instantiate(proyectilAmetralladora, gameObject.transform);
            Timer = 0;
            
        }
    }
}
