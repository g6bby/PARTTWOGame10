using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{
    public GameObject note1;

    private int triggeredNoteCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggeredNoteCount++;
            note1.SetActive(true);

            if (triggeredNoteCount == 5)
            {
                
            }
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
