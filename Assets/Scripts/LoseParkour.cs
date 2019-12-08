using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseParkour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        FindObjectOfType<Level>().GoToGameOverParkour();
    }
}
