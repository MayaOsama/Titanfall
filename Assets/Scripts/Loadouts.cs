using UnityEngine;
using UnityEngine.UI;

public class Loadouts : MonoBehaviour
{

    [SerializeField] GameObject rifle, shotgun, rocket, grenade;

    string primary, secondary;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        rifle.GetComponent<Outline>().enabled = false;
        shotgun.GetComponent<Outline>().enabled = false;
        rocket.GetComponent<Outline>().enabled = false;
        grenade.GetComponent<Outline>().enabled = false;
        primary = "";
        secondary = "";
    }

    public void SelectRifle()
    {
        rifle.GetComponent<Outline>().enabled = true;
        shotgun.GetComponent<Outline>().enabled = false;
        primary = "rifle";
    }

    public void SelectShotgun()
    {
        rifle.GetComponent<Outline>().enabled = false;
        shotgun.GetComponent<Outline>().enabled = true;
        primary = "shotgun";
    }

    public void SelectRocket()
    {
        rocket.GetComponent<Outline>().enabled = true;
        grenade.GetComponent<Outline>().enabled = false;
        secondary = "rocket";
    }

    public void SelectGrenade()
    {
        rocket.GetComponent<Outline>().enabled = false;
        grenade.GetComponent<Outline>().enabled = true;
        secondary = "grenade";
    }

    public string GetPrimary()
    {
        return primary;
    }

    public string GetSecondary()
    {
        return secondary;
    }

    public void StartGame()
    {
        if(primary != "" && secondary != "")
        {
            FindObjectOfType<Level>().GoToFirstLevel();
        }
        else
        {
            Debug.Log("Must choose a primary and a secondary weapon!!");
        }
    }
}
