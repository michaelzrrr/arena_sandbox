using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public new string name;
    public string description;

    [SerializeField]
    public GameObject bulletPrefab;
    
    public int firerate;
    public int magazineSize;
    public int bulletAmount;
    public int reloadTime;
}
