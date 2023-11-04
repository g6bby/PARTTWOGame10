using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{

public GameObject note1;

void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        note1.SetActive(true);
    }
}

void OnTriggerExit(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        note1.SetActive(false);
    } 
}
}
