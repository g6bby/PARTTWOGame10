using System.Collections;
using UnityEngine;
using TMPro;

public class EndText : MonoBehaviour
{
    public GameObject textMeshProPrefab1;
    public GameObject textMeshProPrefab2;
    public GameObject textMeshProPrefab3;
    public GameObject textMeshProPrefab4;
    public GameObject textMeshProPrefab5;
    public GameObject textMeshProPrefab6;
    public GameObject textMeshProPrefab7;
    public GameObject textMeshProPrefab8;
    public GameObject fadeImg;

        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(EnableText());
        }
    }


    
    private IEnumerator EnableText()
    {
        yield return new WaitForSeconds(3f);
        textMeshProPrefab1.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab2.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab3.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab4.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab5.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab6.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab7.SetActive(true);
        yield return new WaitForSeconds(1f);
        textMeshProPrefab8.SetActive(true);
        yield return new WaitForSeconds(3f);
        fadeImg.SetActive(true);

    }
}
