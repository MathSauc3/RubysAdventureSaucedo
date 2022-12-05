using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject theplayer;

    void OnTriggerEnter2D(Collider2D collision)
    {
        theplayer.transform.position = teleportTarget.transform.position;
    }

}
