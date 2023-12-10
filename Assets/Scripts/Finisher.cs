using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    [SerializeField] GameObject completeUICanvas;

    [HideInInspector] public bool gameEnded = false;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            Debug.Log("LEVEL COMPLETE!!!");
            completeUICanvas.SetActive(true);
            gameEnded = true;
        }
    }
}
