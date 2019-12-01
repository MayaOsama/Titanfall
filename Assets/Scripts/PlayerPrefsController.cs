using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{

    const string MUSIC_VOLUME = "music volume";
    const string MUSIC_SFX_VOLUME = "SFX volume";

    public static void SetVolume(string name, float volume)
    {
        if (name == MUSIC_VOLUME)
        {
            SetMusicVolume(volume);
        }
        else
        {
            SetSFXVolume(volume);
        }
    }

    public static float GetVolume(string name)
    {
        if (name == MUSIC_VOLUME)
        {
            return GetMusicVolume();
        }
        else
        {
            return GetSFXVolume();
        }
    }

    private static void SetMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat(MUSIC_VOLUME, volume);
    }

    private static void SetSFXVolume(float volume)
    {
        PlayerPrefs.SetFloat(MUSIC_SFX_VOLUME, volume);
    }

    private static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat(MUSIC_VOLUME, 1);
    }

    private static float GetSFXVolume()
    {
        return PlayerPrefs.GetFloat(MUSIC_SFX_VOLUME, 1);
    }

}
