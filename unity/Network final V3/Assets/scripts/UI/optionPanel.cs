using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class optionPanel : MonoBehaviour
{
    [SerializeField]
    private AudioMixer master;

    public GameObject camera;

    public Dropdown resolutionsDropdown;

    Resolution[] resolutions;

    private void Start() {
        resolutions = Screen.resolutions;
        resolutionsDropdown.ClearOptions();

        List<string> resolutionsName = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            resolutionsName.Add(resolutions[i].width + " x " + resolutions[i].height);
            
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropdown.AddOptions(resolutionsName);
        resolutionsDropdown.value = currentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();
    }

    public void Setresolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume (float volume)
    {
        Debug.Log(volume);
        // master.SetFloat("volume", volume);
        AudioListener.volume = volume; 
    }
}
