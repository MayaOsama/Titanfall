using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    
    [SerializeField] float minHeight, maxHeight, speed;
    int direction = 1;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > maxHeight)
        {
            direction = -1;
        }
        if(transform.position.y < minHeight)
        {
            direction = 1;
        }

        transform.Translate(0, speed * direction * Time.deltaTime, 0);
    }
}
