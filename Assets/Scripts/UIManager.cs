using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inv;
    public GameObject pause;

    public void EnableUI(string ui, bool b)
    {
        if (ui == "inventory")
        {
            inv.SetActive(b);
        }

        if (ui == "pause")
        {
            pause.SetActive(b);
        }
    }
}
