using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobA : MonoBehaviour
{
   
    public GameObject RootA;
    public GameObject RootB;
    public GameObject RootC;
    public GameObject RootD;
    public GameObject RootE;
    public GameObject RootF;

    private float spe = 2.0f;
    private Vector3 direction;
    private Vector3 target;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if(count == 0)
        {
            target = RootA.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        
        if(count == 1)
        {
            target = RootB.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }*/

        Patrol(count);
        direction = target;
        transform.LookAt(new Vector3(direction.x, transform.position.y, direction.z));
        Debug.Log(count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "RootA")||(other.gameObject.name == "RootB")||(other.gameObject.name == "RootC")||(other.gameObject.name =="RootD")||(other.gameObject.name == "RootE")||(other.gameObject.name == "RootF"))
        {
            count++;
        }
    }
    
    private void Patrol(int x)
    {
        switch (x)
        {
            case 0:
                target = RootA.transform.position;
               break;

            case 1:
                target = RootB.transform.position;
                break;

            case 2:
                target = RootC.transform.position;
                break;

            case 3:
                target = RootD.transform.position;
                break;

            case 4:
                target = RootE.transform.position;
                break;

            case 5:
                target = RootF.transform.position;
                break;
            
            case 6:
                count = 0;
                break;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
    }
}
