using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialBehaviour : MonoBehaviour
{
    Material m_Material;

 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Pick a random, saturated and not-too-dark color
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
    

    void OnDestroy()
    {
        //Destroy the instance
        Destroy(m_Material);
        //Output the amount of materials to show if the instance was deleted
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }
}
