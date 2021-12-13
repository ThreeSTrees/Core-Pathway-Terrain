using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    public Vector3 start;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.position;
        rotation = this.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 0));
    }

    void OnCollisionEnter(Collision hit)    
    {
        Debug.Log("Hit something");
        if (hit.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            Debug.Log("Player contact");
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Hit something");
        if (hit.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            Debug.Log("Player contact");
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered something");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player contact");
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
