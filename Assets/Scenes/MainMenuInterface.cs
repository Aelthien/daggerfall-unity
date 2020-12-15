using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuInterface : MonoBehaviour
{
    public void OpenMods()
    {
        Debug.Log("Mods");
    }

    public void Play()
    {
        SceneManager.LoadScene(DaggerfallWorkshop.Game.Utility.SceneControl.GameSceneIndex);

    }

    public void OpenAdvanced()
    {
        Debug.Log("Advanced");
    }
}
