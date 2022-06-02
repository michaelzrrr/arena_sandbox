using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanillaGun : MonoBehaviour
{
    [SerializeField]
	private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireProjectile();
    }

    public void FireProjectile()
	{		
		if (OVRInput.GetDown(OVRInput.Button.Four))
		{
			GameObject spawnedProjectile = Instantiate(projectile, transform.position, transform.rotation);
            Vector3 transformPosition = transform.position;
			spawnedProjectile.GetComponent<Projectile>().direction = transform.forward;
		}
	}
}
