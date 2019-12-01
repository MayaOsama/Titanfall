using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] GameObject menu, options, credits, controls, volume;

    private void Start()
    {
        volume.GetComponent<AudioManager>().Initialize();
        SetMenuActive();
    }

    public void SetMenuActive()
    {
        menu.SetActive(true);
        options.SetActive(false);
        credits.SetActive(false);
        controls.SetActive(false);
        volume.SetActive(false);
    }

    public void SetOptionsActive()
    {
        menu.SetActive(false);
        options.SetActive(true);
        credits.SetActive(false);
        controls.SetActive(false);
        volume.SetActive(false);
    }

    public void SetCreditsActive()
    {
        menu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(true);
        controls.SetActive(false);
        volume.SetActive(false);
    }

    public void SetControlsActive()
    {
        menu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        controls.SetActive(true);
        volume.SetActive(false);
    }

    public void SetAudioActive()
    {
        menu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        controls.SetActive(false);
        volume.SetActive(true);
    }

}
