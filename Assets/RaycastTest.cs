using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.forward * 500);
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit raycastHit, Mathf.Infinity))
        {
            Destroy(raycastHit.transform.gameObject);
            Debug.Log("I hit something");
        }
    }
}
