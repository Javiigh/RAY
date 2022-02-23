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
    public AudioSource ButtonSound;

    IEnumerator Start()
    {
        yield return LocalizationSettings.InitializationOperation;

        RestoreLang();
    }

    public void ClickEnglishB()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        index = 0;
        ButtonSound.Play(0);
    }

    public void ClickEspañolB()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
        index = 1;
        ButtonSound.Play(0);
    }

    public void SaveLang()
    {

        PlayerPrefs.SetInt("langIndex", index);
        PlayerPrefs.Save();
    }

    public void RestoreLang()
    {
        index = PlayerPrefs.GetInt("langIndex", 0);
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
}
