using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour
{
    void Update()
    {
        if (transform.childCount == 0)
        {
            Destroy(gameObject);
            if (gameObject.tag == "Spider")
            {
                Debug.Log("Spiders have been eliminated");
            }

            if (gameObject.tag == "Humanoid")
            {
                Debug.Log("Humanoids have been eliminated");
            }

            if (gameObject.tag == "Ogre")
            {
                Debug.Log("Ogres have been eliminated");
            }
        }
    }
}
