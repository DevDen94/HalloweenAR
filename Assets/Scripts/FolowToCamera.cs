using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowToCamera : MonoBehaviour
{
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.gameObject.transform.position);
        transform.Translate(Vector3.forward * 2f * Time.deltaTime);
    }

   
}
