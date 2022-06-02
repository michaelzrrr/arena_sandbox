using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightPointer : MonoBehaviour
{
    private LineRenderer pointer;

    // Start is called before the first frame update
    void Start()
    {
        pointer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RenderLine(transform.position, transform.forward, 5f);
        pointer.enabled = true;
    }

    void RenderLine(Vector3 targetPos, Vector3 direction, float length){
        Ray ray = new Ray(targetPos, direction);
        Vector3 endPos = targetPos + (direction * length);

        if(Physics.Raycast(ray, out RaycastHit rayHit, length)) {
            endPos = rayHit.point;
        }

        pointer.SetPosition(0, targetPos);
        pointer.SetPosition(1, endPos);
    }
}
