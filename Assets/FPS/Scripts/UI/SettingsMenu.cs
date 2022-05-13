using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public Toggle fullscreenToggle;
    public TMP_Dropdown resolutionsDropdown;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            resolutionsDropdown.options.Add(new TMP_Dropdown.OptionData(
                Screen.resolutions[i].width +
                "x" +
                Screen.resolutions[i].height));

            resolutionsDropdown.RefreshShownValue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resIndex)
    {
        Resolution res = Screen.resolutions[resIndex];

        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
