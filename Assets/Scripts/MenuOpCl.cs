using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuOpCl : MonoBehaviour
{
    public void openClose()
    {
        if(gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
