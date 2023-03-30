using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            Debug.Log("Space is down" + down);
        }
        else if(held)
        {
            Debug.Log("Space is Held" + held);
        }
        else if(up)
        {
            Debug.Log("Space is Up: " + up);
        }
        Debug.Log("Space is down: " + down);
        Debug.Log("Space is held: " + held);
        Debug.Log("Space is up: " + up);
    }
}