using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> Trigger
/// This script was created on 10/30/2022 by Oan COQUILLE for the project "La Boite A transformation"
/// The purpose of this script is to be use as a refrence of the scrip GameManager for a trigger detection with the void OnTriggerEnter
/// If the ObjectTag was what the declare say then trigger the GameManagerScript reference
/// </summary>
public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        #region Cube
        if (other.tag == "CUBEBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingCBLEU(this);
        }
        else if (other.tag == "CUBEROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingCRED(this);
        }
        #endregion
        #region Balle
        else if (other.tag == "BALLEBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingBBLEU(this);
        }
        else if (other.tag == "BALLEROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingBRED(this);
        }
        #endregion
        #region Cylindre
        else if (other.tag == "CYLINDREBLEU")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingCYBLEU(this);
        }
        else if (other.tag == "CYLINDREROUGE")
        {
            transform.parent.GetComponent<GameManager>().TriggerColorChangingCYRED(this);
        }
        #endregion
    }
}
