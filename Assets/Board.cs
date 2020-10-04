using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float spd = 3f;
    public Transform target;
    public GameObject bullet;
    public GameObject forward;

    private Vector3 zAxis = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        transform.RotateAround(target.position, zAxis, spd * -h * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Instantiate(bullet,,Quaternion.identity);
        }
    }
}
