using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float spd = 3f;
    public float shooterCoolDown = 1f;
    public Transform target;
    public GameObject bullet;
    public GameObject forward;
    public GameObject origin;

    private Vector3 zAxis = new Vector3(0, 0, 1);
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        transform.RotateAround(target.position, zAxis, spd * -h * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (timer < Time.time)
            {
                Debug.Log(origin.transform.position);
                Instantiate(bullet, new Vector3(origin.transform.position.x - 5,origin.transform.position.y), origin.transform.rotation);
                timer = Time.time + shooterCoolDown;
            }
        }
    }
}
