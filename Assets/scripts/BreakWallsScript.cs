using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWallsScript : MonoBehaviour
{

    public GameObject wall;
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}