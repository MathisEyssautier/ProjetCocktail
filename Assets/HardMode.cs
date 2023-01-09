using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HardMode : MonoBehaviour
{
    public GameObject book;
    public GameObject cahier;
    public void openClose()
    {
        if (book.activeSelf)
        {
            book.SetActive(false);
        }
        else
        {
            book.SetActive(true);
        }

        cahier.SetActive(false);
    }
}
