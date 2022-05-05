using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangingSizeMoins : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BALLEBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerSizeChangingMoinsBBleu(this);
        }
    }

}
