using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision){
        if (collision.CompareTag("projectile")) {
            Destroy(collision.gameObject);
        }
    }
}
