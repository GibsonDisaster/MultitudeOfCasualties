using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);

		gameObject.transform.position = new Vector3(newPos.x, newPos.y, 10);
    }
}
