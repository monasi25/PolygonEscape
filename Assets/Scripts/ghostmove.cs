using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostmove : MonoBehaviour
{
    private CharacterController ghocha;
    private Vector3 dest;
    private float spe = 8.0f;
    private Vector3 velo;
    private Vector3 dire;
    private float rotateSpeed = 3.0f;

    public GameObject player;
    public GameObject pointa;
    public GameObject pointb;
    public GameObject pointc;
    public GameObject pointd;
    public GameObject pointe;
    public GameObject pointf;
    public GameObject pointg;
    public GameObject pointh;
    public GameObject pointi;
    public GameObject pointj;
    public GameObject pointk;
    public GameObject pointl;
    public GameObject pointm;
    public GameObject pointn;
    public GameObject pointo;
    

    private Vector3 target;

    private int count = 0;

    private bool check1 = false;
    private bool check2 = false;
    private bool check3 = false;
    private bool check4 = false;
    private bool check5 = false;
    private bool check6 = false;
    private bool check7 = false;
    private bool check8 = false;
    private bool check9 = false;
    private bool check10 = false;
    private bool check11 = false;
    private bool check12 = false;
    private bool check13 = false;
    private bool check14 = false;
    private bool check15 = false;
    private bool check16 = false;
    private bool check17 = false;
    private bool check18 = false;
    private bool check19 = false;
    

    private int i = 0;

    private Vector3 latestPos;
    // Start is called before the first frame update
    void Start()
    {
        ghocha = GetComponent<CharacterController>();
        velo = Vector3.zero;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
            Vector3 diff = transform.position - latestPos;
            latestPos = transform.position;
            transform.rotation = Quaternion.LookRotation(diff);
        
        if (check1 == false)
        { 
            target = pointc.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
            
        }

        if((check1 == true) && (check2 == false))
        {
            target = pointl.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
           
        }
        if((check2 == true)&&(check3 == false))
        {
            target = pointm.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
       if((check3 == true)&&(check4 == false))
       {
            target = pointn.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check4 == true)&&(check5 == false))
       {
            target = pointo.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check5 == true)&&(check6 == false))
       {
            target = pointi.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check6 == true)&&(check7 == false))
       {
            target = pointj.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check7 == true)&&(check8 == false))
       {
            target = pointk.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check8 == true)&&(check9 == false))
       {
            target = pointd.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check9 == true)&&(check10 == false))
       {
            target = pointe.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check10 == true)&&(check11 == false))
       {
            target = pointh.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check11 == true)&&(check12 == false))
       {
            target = pointg.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check12 == true)&&(check13 == false))
       {
            target = pointf.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check13 == true)&&(check14 == false))
       {
            target = pointe.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check14 == true)&&(check15 == false))
       {
            target = pointh.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check15 == true)&&(check16 == false))
       {
            target = pointg.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       if((check16 == true)&&(check17 == false))
       {
            target = pointa.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
       }
       
    }
     private void OnTriggerEnter(Collider other)
    {
          
        if((other.gameObject.name == "pointc")&&(count== 0))
        {
            check1 = true;
            count++;
        }   
     
        if((other.gameObject.name == "pointl")&&(count == 1))
        {
            check2 = true;
            count++;
        }
     
        if((other.gameObject.name == "pointm")&&(count == 2))
        {
            check3 = true;
            count++;
        }

        if((other.gameObject.name == "pointn")&&(count == 3))
        {
            check4 = true;
            count++;
        }
        
        if ((other.gameObject.name == "pointo")&&(count == 4))
        {
            check5 = true;
            count++;
        }

        if ((other.gameObject.name == "pointi")&&(count == 5))
        {
            check6 = true;
            count++;
        }

        if ((other.gameObject.name == "pointj")&&(count == 6))
        {
            check7 = true;
            count++;
        }

        if ((other.gameObject.name == "pointk")&&(count == 7))
        {
            check8 = true;
            count++;
        }

        if ((other.gameObject.name == "pointd")&&(count == 8))
        {
            check9 = true;
            count++;
        }

        if ((other.gameObject.name == "pointe")&&(count == 9))
        {
            check10 = true;
            count++;
        }

        if ((other.gameObject.name == "pointh")&&(count == 10))
        {
            check11 = true;
            count++;
        }

        if ((other.gameObject.name == "pointg")&&(count == 11))
        {
            check12 = true;
            count++;
        }

        if ((other.gameObject.name == "pointf")&&(count == 12))
        {
            check13 = true;
            count++;
        }

        if ((other.gameObject.name == "pointe")&&(count == 13))
        {
            check14 = true;
            count++;
        }

        if ((other.gameObject.name == "pointh")&&(count == 14))
        {
            check15 = true;
            count++;
        }

        if ((other.gameObject.name == "pointg")&&(count == 15))
        {
            check16 = true;
            count++;
        }

        if ((other.gameObject.name == "pointa")&&(count == 16))
        {
            check1 = false;
            check2 = false;
            check3 = false;
            check4 = false;
            check5 = false;
            check6 = false;
            check7 = false;
            check8 = false;
            check9 = false;
            check10 = false;
            check11 = false;
            check12 = false;
            check13 = false;
            check14 = false;
            check15 = false;
            check16 = false;
            count = 0;
        }


    }
    
}
