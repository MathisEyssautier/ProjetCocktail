using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject pannelToDisplay;
    public GameObject pannelToDisplay2;
    public GameObject pannelToDisplay3;
    public void StartGame()
    {
        gameObject.SetActive(false);
        pannelToDisplay.SetActive(true);
        pannelToDisplay2.SetActive(true);
        pannelToDisplay3.SetActive(true);
    }
}
