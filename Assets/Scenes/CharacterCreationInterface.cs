using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreationInterface : MonoBehaviour
{
    public GameObject raceSelector;
    public GameObject classSelector;
    public GameObject startSelector;

    void Awake()
    {
    }

    public void OnRaceTab()
    {
        if (!raceSelector.activeInHierarchy)
        {
            raceSelector.SetActive(true);

            classSelector.SetActive(false);
            startSelector.SetActive(false);
        }
    }

    public void OnClassTab()
    {
        if (!classSelector.activeInHierarchy)
        {
            classSelector.SetActive(true);

            raceSelector.SetActive(false);
            startSelector.SetActive(false);
        }
    }

    public void OnStartTab()
    {
        if (!startSelector.activeInHierarchy)
        {
            startSelector.SetActive(true);

            classSelector.SetActive(false);
            raceSelector.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
