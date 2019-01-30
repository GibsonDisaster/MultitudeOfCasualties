using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToDestination(GameObject g)
    {
        Debug.Log("Colliding!");

        g.transform.position = new Vector3(destination.x, destination.y, destination.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        MoveToDestination(other.gameObject);
    }
}
