using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kadai : MonoBehaviour
{
    private GameObject unitychan;
    public GameObject cam;
    public GameObject fab;
    private float difference;

    void Start()
    {

        this.cam = GameObject.Find("Main Camera");
        this.fab = this.gameObject;

        //this.difference = cam.transform.position.z - fab.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (fab.transform.position.z < cam.transform.position.z)
        {
            GameObject.Destroy(fab);
        }



    }

   
}
