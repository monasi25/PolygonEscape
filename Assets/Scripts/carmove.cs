using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour
{
    public GameObject carpointa;
    public GameObject carpointb;
    private float speed = 9.0f;
    private Vector3 target;
    private int count = 0;
    private Vector3 direction;
    private float kaitenSpeed = 400.0f;
    private bool check1 = false;

    public Transform[] wheelcolliders = new Transform[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check1 == false)
        {
            target = carpointa.transform.position;
            direction = carpointa.transform.position;
            transform.LookAt(new Vector3(direction.x, transform.position.y, direction.z));
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
       
        if(check1 == true)
        {
            target = carpointb.transform.position;
            direction = carpointb.transform.position;
            Curve(direction);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "CarpointA")
        {
            check1 = true;
        }
    }

    void Curve(Vector3 angle)
    {
        Quaternion q = Quaternion.LookRotation(angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, kaitenSpeed * Time.deltaTime);
    }
}
