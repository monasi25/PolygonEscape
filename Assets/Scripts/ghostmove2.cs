using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostmove2 : MonoBehaviour
{
    private CharacterController ghocha;
    private Vector3 dest;
    private float spe = 8.0f;
    private Vector3 velo;
    private Vector3 dire;
    private float rotateSpeed = 3.0f;

    public GameObject player;
    public GameObject pointr;
    public GameObject pointq;
    public GameObject pointp;
    public GameObject points;
    public GameObject pointf;
    public GameObject pointi;
    public GameObject pointj;
    public GameObject pointb;
    public GameObject pointc;
    public GameObject pointy;
    public GameObject pointx;

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
            target = pointq.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }

        if ((check1 == true) && (check2 == false))
        {
            target = pointp.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check2 == true) && (check3 == false))
        {
            target = points.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check3 == true) && (check4 == false))
        {
            target = pointf.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check4 == true) && (check5 == false))
        {
            target = pointi.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check5 == true) && (check6 == false))
        {
            target = pointj.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check6 == true) && (check7 == false))
        {
            target = pointb.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check7 == true) && (check8 == false))
        {
            target = pointc.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check8 == true) && (check9 == false))
        {
            target = pointy.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check9 == true) && (check10 == false))
        {
            target = pointx.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check10 == true) && (check11 == false))
        {
            target = pointf.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        if ((check11 == true) && (check12 == false))
        {
            target = pointr.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, spe * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.name == "pointq") && (count == 0))
        {
            check1 = true;
            count++;
        }

        if ((other.gameObject.name == "pointp") && (count == 1))
        {
            check2 = true;
            count++;
        }

        if ((other.gameObject.name == "points") && (count == 2))
        {
            check3 = true;
            count++;
        }

        if ((other.gameObject.name == "pointf") && (count == 3))
        {
            check4 = true;
            count++;
        }

        if ((other.gameObject.name == "pointi") && (count == 4))
        {
            check5 = true;
            count++;
        }

        if ((other.gameObject.name == "pointj") && (count == 5))
        {
            check6 = true;
            count++;
        }

        if ((other.gameObject.name == "pointb") && (count == 6))
        {
            check7 = true;
            count++;
        }

        if ((other.gameObject.name == "pointc") && (count == 7))
        {
            check8 = true;
            count++;
        }

        if ((other.gameObject.name == "pointy") && (count == 8))
        {
            check9 = true;
            count++;
        }

        if ((other.gameObject.name == "pointx") && (count == 9))
        {
            check10 = true;
            count++;
        }

        if ((other.gameObject.name == "pointf") && (count == 10))
        {
            check11 = true;
            count++;
        }

        if ((other.gameObject.name == "pointr") && (count == 11))
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
            count = 0;
        }
    }
}
