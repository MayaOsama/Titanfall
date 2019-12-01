using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioMixer mixer;

    [SerializeField] AudioSetting[] audioSettings;

    private enum AudioGroups
    {
        Music,
        SFX
    };

    void Awake()
    {
        instance = GetComponent<AudioManager>();
    }

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        for (int i = 0; i < audioSettings.Length; i++)
        {
            audioSettings[i].Initialize();
        }
    }

    public void SetMusicVolume(float value)
    {
        audioSettings[(int)AudioGroups.Music].SetExposedParam(value);
    }

    public void SetSFXVolume(float value)
    {
        audioSettings[(int)AudioGroups.SFX].SetExposedParam(value);
    }

    private void Update()
    {
        SetMusicVolume(audioSettings[(int)AudioGroups.Music].GetSliderValue());
        SetSFXVolume(audioSettings[(int)AudioGroups.SFX].GetSliderValue());
    }

}

[System.Serializable]
public class AudioSetting
{
    [SerializeField] Slider slider;
    [SerializeField] string exposedParam;

    public void Initialize()
    {
        if (PlayerPrefsController.GetVolume(exposedParam) == 1)
        {
            slider.value = -20;
            SetExposedParam(-20);
        }
        else
        {
            slider.value = PlayerPrefsController.GetVolume(exposedParam);
            SetExposedParam(PlayerPrefsController.GetVolume(exposedParam));
        }
    }

    public float GetSliderValue()
    {
        return slider.value;
    }

    public void SetExposedParam(float value)
    {
        AudioManager.instance.mixer.SetFloat(exposedParam, value);
        PlayerPrefsController.SetVolume(exposedParam, value);
    }

}
