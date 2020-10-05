using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int health = 10;

    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameMaster>().GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (gameObject.tag == "Planet")
            {
                gm.GameOver();
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
