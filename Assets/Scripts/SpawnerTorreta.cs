using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTorreta : MonoBehaviour
{
    public GameObject proyectilTorreta;
    public float Timer;
    public int TimeToSpawn;
    public int min = 1;
    public int max = 2;


    // Start is called before the first frame update
    void Start()
    {
        TimeToSpawn = Random.Range(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= TimeToSpawn)
        {
            Instantiate(proyectilTorreta, transform);
            Timer = 0;
            TimeToSpawn = Random.Range(min, max);
        }
    }
}
