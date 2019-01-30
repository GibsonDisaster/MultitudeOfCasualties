using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void ContinueButton()
    {
        GameObject.Find("Player").GetComponent<Player>().paused = false;
        GameObject.Find("Player").GetComponent<Rigidbody2D>().simulated = true;
        GameObject.Find("UIManager").GetComponent<UIManager>().EnableUI("pause", false);
    }

    public void QuitButton()
    {
        Debug.Log("QUITTING");
        Application.Quit();
    }
}
