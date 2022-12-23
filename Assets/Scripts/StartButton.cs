using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject pannelToDisplay;
    public void StartGame()
    {
        gameObject.SetActive(false);
        pannelToDisplay.SetActive(true);
    }
}
