using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
public class AudioSettings : MonoBehaviour
{
    private const string MUSIC_KEY = "MusicVolume";
    private const string SFX_KEY = "SFXVolume";

    private void Start()

    {
        LoadSettings();
    }
    public void LoadSettings()
    {
        float musicVol = PlayerPrefs.GetFloat(MUSIC_KEY, 0f);
        float sfxVol = PlayerPrefs.GetFloat(SFX_KEY, 0f);

        AudioManager.Instance.SetMusicVolume(musicVol);
        AudioManager.Instance.SetSFXVolume(sfxVol);
    }
    public void SetMusicVolume(float volume)

    {
        AudioManager.Instance.SetMusicVolume(volume);
        PlayerPrefs.SetFloat(MUSIC_KEY, volume);
        PlayerPrefs.Save();
    }
    public void SetSFXVolume(float volume)

    {
        AudioManager.Instance.SetSFXVolume(volume);
        PlayerPrefs.SetFloat(SFX_KEY, volume);
       PlayerPrefs.Save();
    }
}