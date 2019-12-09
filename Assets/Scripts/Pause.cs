using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    [SerializeField] Canvas canvas;
    [SerializeField] GameObject player;
    bool paused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            paused = true;
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Unpause()
    {
        paused = false;
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public bool IsPaused()
    {
        return paused;
    }
}
