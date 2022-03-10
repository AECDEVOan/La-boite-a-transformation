using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNochanging : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        #region cube
        if (other.tag == "CUBEBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingCBLUE(this);
        }
        #endregion
    }
}
