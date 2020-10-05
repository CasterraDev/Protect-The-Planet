using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public AnimationCurve spawnRateAnim;
    public float spawnRate = 2f;
    public GameObject ship;
    public float timer;

    private Vector2 screenBounds;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        Debug.Log("X: " + screenBounds.x + "    " + "Y: " + screenBounds.y);
        gm = FindObjectOfType<GameMaster>().GetComponent<GameMaster>();
        gm.TurnOffGameOverScreen();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Time.time && gm.gamePlaying)
        {
            SpawnShip();
            timer = Time.time + spawnRateAnim.Evaluate(Time.time/10);
            Debug.Log("TIme" + spawnRateAnim.Evaluate((Time.time/10)));
        }
    }

    public void SpawnShip()
    {
        var shot = Instantiate(ship);
        Vector2 shipVec = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * RandomPosOrNeg());
        shot.transform.position = shipVec;
    }

    //Gives either -1 or 1
    public int RandomPosOrNeg()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
