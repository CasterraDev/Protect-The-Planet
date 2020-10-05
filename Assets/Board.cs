using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float spd = 3f;
    public float bulletSpd = 5f;
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

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(origin.transform.position);
            var shot = Instantiate(bullet, origin.transform.position, origin.transform.rotation);
            shot.GetComponent<Bullet>().spd = bulletSpd;
            timer = Time.time + shooterCoolDown;
        }
    }
}
