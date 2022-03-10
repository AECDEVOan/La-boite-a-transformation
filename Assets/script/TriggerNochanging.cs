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
        else if (other.tag == "CUBEROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingCRED(this);
        }
        #endregion
        #region BALLE
        else if (other.tag == "BALLEBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingBBLUE(this);
        }
        else if (other.tag == "BALLEROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingBRED(this);
        }
        #endregion
        #region CYLINDRE
        else if (other.tag == "CYLINDREBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingCYBLUE(this);
        }
        else if (other.tag == "CYLINDREROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerNoChangingCYRED(this);
        }
        #endregion
    }
}
