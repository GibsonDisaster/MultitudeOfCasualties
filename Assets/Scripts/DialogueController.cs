using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public GameObject dialogueWindow, textBox, nameText, portraitImage;

    public void DoDialogue(string name, string[] sentences, Sprite portrait)
    {
        dialogueWindow.SetActive(true);
        Debug.Log(name);
        Debug.Log(sentences[0]);

        textBox.GetComponent<Text>().text = sentences[0];
        nameText.GetComponent<Text>().text = name;
        portraitImage.GetComponent<Image>().sprite = portrait;
    }

    public void CloseDialogue()
    {
        dialogueWindow.SetActive(false);
    }
}
