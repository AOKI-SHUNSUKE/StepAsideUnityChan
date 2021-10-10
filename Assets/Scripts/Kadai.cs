using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai : MonoBehaviour
{
   
    void OnBecameInvisible()
    {
        // 表示されなくなった時の処理
        GameObject.Destroy(this.gameObject);
    }
}
