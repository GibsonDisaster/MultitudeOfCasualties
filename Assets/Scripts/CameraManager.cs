using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class CameraManager : MonoBehaviour
{
    public GameObject player;

    Transform t, pt;

    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.GetComponent<Transform>();
        pt = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SETTING");
        t.position.Set(pt.position.x, pt.position.y, t.position.z);
    }
}
