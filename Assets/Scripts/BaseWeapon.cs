using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    public float nextTimeToFire = 0f;

    [SerializeField]
    protected Gun gunSO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > .5 && transform.GetComponent<OVRGrabbable>().isGrabbed) {
            if (CheckFireRate()) {
                GameObject spawnedProjectile = Instantiate(gunSO.bulletPrefab, transform.position, transform.rotation);
                Vector3 transformPosition = transform.position;
                spawnedProjectile.GetComponent<Projectile>().direction = transform.forward;
            }
        }
    }

    bool CheckFireRate() {
        if (Time.time >= nextTimeToFire) {
            nextTimeToFire = Time.time + (1f / gunSO.firerate);
            return true;
        }
        return false;
    }

}

