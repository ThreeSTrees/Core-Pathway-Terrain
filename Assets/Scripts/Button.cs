using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject platform;
    public Vector3 moveGap;
    public bool rightbutton;
    public bool leftbutton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (rightbutton & platform.GetComponent<ButtonPlatform>().maxdistance >= 1)
            {
                platform.transform.Translate(moveGap);
                platform.GetComponent<ButtonPlatform>().maxdistance--;
                platform.GetComponent<ButtonPlatform>().mindistance++;
            }
            if (leftbutton & platform.GetComponent<ButtonPlatform>().mindistance >= 1)
            {
                platform.transform.Translate(moveGap);
                platform.GetComponent<ButtonPlatform>().mindistance--;
                platform.GetComponent<ButtonPlatform>().maxdistance++;
            }
        }
    }
}
