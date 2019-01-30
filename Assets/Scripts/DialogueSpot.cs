using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSpot : MonoBehaviour
{
    public GameObject anchor, dialogueManager;
    public Sprite portrait;

    public bool mouseIn = false;

    public string name;
    [TextArea(3, 10)]
    public string[] sentences;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = anchor.transform.position + new Vector3(0.75f, 0.75f, 0);

        if (Input.GetMouseButtonDown(1))
        {
            dialogueManager.GetComponent<DialogueController>().DoDialogue(name, sentences, portrait);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mouse"))
            mouseIn = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Mouse"))
            mouseIn = false;
    }
}
