using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCHangingSize : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BALLEBLEU")
        {
            Debug.Log("trigger");
            other.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, -0.2f);
        }
    }
}
