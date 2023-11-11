using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{
    public GameObject note1;
    public GameObject inkblot;
    public GameObject particleEffects;
    public GameObject endCollider;
    public GameObject noteCollider;
    public GameObject noteText;

    private bool canPickUpNote = false;
    //private int triggeredNoteCount = 0;


void Start()
{
    inkblot.SetActive(false);
    particleEffects.SetActive(false);
    endCollider.SetActive(false);
}

void Update()
    {
        if (canPickUpNote && Input.GetKeyDown(KeyCode.E))
        {
            GameManager.triggeredNoteCount++;
            Debug.Log("triggeredNoteCount: " + GameManager.triggeredNoteCount);
            note1.SetActive(false);
            noteCollider.SetActive(false);
            noteText.SetActive(false);

            if (GameManager.triggeredNoteCount == 5)
            {
                inkblot.SetActive(true);
                particleEffects.SetActive(true);
                endCollider.SetActive(true);
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            note1.SetActive(true);
            canPickUpNote = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            note1.SetActive(false);
            canPickUpNote = false;
        }
    }

}
