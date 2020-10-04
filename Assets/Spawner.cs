using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 10f;
    public GameObject ship;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > Time.time)
        {
            SpawnShip();
            timer = Time.time + spawnRate;
        }
    }

    public void SpawnShip()
    {

        Instantiate(ship);
    }
}
