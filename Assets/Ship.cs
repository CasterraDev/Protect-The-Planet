using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float spd;
    public Transform planet;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 offset = planet.position - transform.position;

        transform.rotation = Quaternion.LookRotation(
                               Vector3.forward, // Keep z+ pointing straight into the screen.
                               offset           // Point y+ toward the target.
                             );
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1 * spd * Time.deltaTime, 0), Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Board"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Planet"))
        {
            Destroy(gameObject);
        }
    }
}
