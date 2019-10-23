using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    public int EndGemCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Grab")
        {
            EndGemCount++;
            Destroy(collision.gameObject);
        }
        
    }
}
