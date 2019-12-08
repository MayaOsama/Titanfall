using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingBoxes : MonoBehaviour
{
    
    [SerializeField] float speed;
     int direction = 1;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > -15f)
        {
            direction = -1;
        }
        if(transform.position.z < -45f)
        {
            direction = 1;
        }

        transform.Translate(0, 0, speed * direction * Time.deltaTime);
    }
}
