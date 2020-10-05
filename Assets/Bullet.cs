using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float spd = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-spd * Time.deltaTime, 0, 0),Space.Self);
        Destroy(gameObject, 1000 * Time.deltaTime);
    }
}
