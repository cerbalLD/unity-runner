using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesDelete : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground_Tile1"))
        {
            Destroy(collision.gameObject);
        }
    }
}
