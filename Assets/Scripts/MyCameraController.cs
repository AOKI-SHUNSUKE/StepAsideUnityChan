using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    private GameObject unitychan; //private GameObject itemGenerator;

    private GameObject coinPrefab;
    private GameObject carPrefab;
    private GameObject conePrefab;

    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

       

        this.coinPrefab = GameObject.Find("CoinPrefab(Clone)");
        this.carPrefab = GameObject.Find("CarPrefab(Clone)");
        this.conePrefab = GameObject.Find("TrafficConePrefab(Clone)");

        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);



        if(coinPrefab == null)
        {
            return;
        }

            if (this.coinPrefab.transform.position.z < (this.unitychan.transform.position.z - difference))
            {
                Destroy(this.coinPrefab);
            }

        if (carPrefab == null)
        {
            return;
        }

        if (this.carPrefab.transform.position.z < (this.unitychan.transform.position.z - (difference - 1)))
        {
            Destroy(this.carPrefab);
        }
        if (conePrefab == null)
        {
            return;
        }

        if (this.conePrefab.transform.position.z < (this.unitychan.transform.position.z - (difference - 1) ))
        {
            Destroy(this.conePrefab);
        }



        //if (GameObject.Find("CoinPrefab(Clone)").transform.position.z < this.unitychan.transform.position.z - difference)
        //    {
        //        Destroy(this.itemGenerator.transform.GetChild(index));
        //    }
        //if (GameObject.Find("TrafficConePrefab(Clone)").transform.position.z < this.unitychan.transform.position.z - difference)
        //{
        //    Destroy(GameObject.Find("TrafficConePrefab(Clone)").transform.position.z);
        //}
    }
}
