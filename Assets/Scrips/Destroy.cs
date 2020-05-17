using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }

}
