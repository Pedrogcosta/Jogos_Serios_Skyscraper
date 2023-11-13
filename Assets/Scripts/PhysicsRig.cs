using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRig : MonoBehaviour
{
    public Transform playerhead;
    public CapsuleCollider body;

    public float bodyHeightMin = 0.5f;
    public float bodyHeightMax = 2.0f;


    void FidexUpdate ()
    {
        body.height = Mathf.Clamp(playerhead.localPosition.y, bodyHeightMin, bodyHeightMax);
        body.center = new Vector3(playerhead.localPosition.x, body.height / 2, playerhead.localPosition.z);
    }
}
