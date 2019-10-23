using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelreset : MonoBehaviour
{
    public int EndGem = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Grab")
        {
            EndGem++;
                if(EndGem > 0)
            {
                SceneManager.LoadScene("Win");
                //SceneManager.LoadScene("Win);
            }
        }
    }
}
