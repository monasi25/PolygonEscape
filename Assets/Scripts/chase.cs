using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    
    public GameObject player;
    private Vector3 velocity;
    private Vector3 direction;
    private float spe = 4.0f;
    private float i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.position;
        transform.LookAt(new Vector3(direction.x, transform.position.y, direction.z));
        transform.position = Vector3.MoveTowards(transform.position, direction, spe * Time.deltaTime);

        if ((i <= 500))
        {
            transform.Translate(0, 0.01f, 0);

        }
        if (i > 500)
        {
            transform.Translate(0, -0.02f, 0);

            if (i == 600)
            {
                i = 0;
            }
        }
        i++;
    }
}
