using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy") {
            Debug.Log("Bang");
            Destroy(collision.gameObject);
        }
    }
}
