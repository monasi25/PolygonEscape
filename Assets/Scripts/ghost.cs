using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    private int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if ((i <= 300))
            {
                transform.Translate(0, 0.01f, 0);

            }
            if (i > 300)
            {
                transform.Translate(0, -0.01f, 0);

                if (i == 450)
                {
                    i = 0;
                }
            }
            i++;
        
    }
}
