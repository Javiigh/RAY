using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class ChangeLenguage : MonoBehaviour
{
    int index = 0;
    public Button EnglishB;
    public Button EspañolB;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            index++;
            if(index > 2)
            {
                index = 0;
            }
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            index++;
            if (index < 0)
            {
                index = 2;
            }
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        }
    }

    public void ClickEnglishB()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }

    public void ClickEspañolB()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
    }
}
