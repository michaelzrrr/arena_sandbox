using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGame : MonoBehaviour
{
    public static int numTargets = 0;

    [SerializeField]
	private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", 2.0f, 5.0f);
    }

    void SpawnTarget() {

        if (numTargets < 5)
        {
            var position = new Vector3(10, Random.Range(0, 10), Random.Range(-10.0f, 10.0f));
            Quaternion rotation = Quaternion.Euler(0, 0, 90);
            GameObject spawnedTarget = Instantiate(target, position, rotation);
            numTargets++;
        }

    }
}
