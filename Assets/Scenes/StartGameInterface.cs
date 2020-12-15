using DaggerfallWorkshop.Game.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameInterface : MonoBehaviour
{
    StartGameBehaviour startGameBehaviour;
    public GameObject characterCreator;

    void Awake()
    {
        startGameBehaviour = GameObject.FindObjectOfType<StartGameBehaviour>();

        if (!startGameBehaviour)
            throw new Exception("Could not find StartGameBehaviour in scene.");
    }

    public void OnLoadGame()
    {
        startGameBehaviour.StartMethod = StartGameBehaviour.StartMethods.LoadDaggerfallUnitySave;
        Destroy(gameObject);
    }

    public void OnNewGame()
    {
        gameObject.SetActive(false);
        characterCreator.SetActive(true);
        //startGameBehaviour.StartMethod = StartGameBehaviour.StartMethods.NewCharacter;
        //Destroy(gameObject);
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
