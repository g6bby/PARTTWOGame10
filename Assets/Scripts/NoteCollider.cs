using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{
    public GameObject note1;
    public GameObject inkblot;
    public GameObject particleEffects;
    public GameObject endCollider;

    private int triggeredNoteCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggeredNoteCount++;
            note1.SetActive(true);

            StartCoroutine(NextSceneDelay());
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

    IEnumerator NextSceneDelay()
    {
        yield return new WaitForSeconds(15f);

        inkblot.SetActive(true);
        particleEffects.SetActive(true);
        endCollider.SetActive(true);
    }
}
