using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    [SerializeField] Text bumpedThingsText;

    private int hits = 0;
    private string hitCountMsg;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Ground")
        {   
            if (other.gameObject.tag != "Hit")
            {
                hits++;
                hitCountMsg = "You've bumped " + hits + " times";
                Debug.Log(hitCountMsg);
                bumpedThingsText.text = hitCountMsg;
            }
        }
    }
}
