using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> GameManager [Gestion Boite]
/// This script was created on 03/10/2022 by Oan COQUILLE for the project "La boite a transformation"
/// The purpose of this script is to define the game rules of the transformation box. 
/// It is compose of trigger area with tag spawner of a prefab gameobject list. 
/// </summary>
/// Version 1.0 on 03/10/2022

public class GameManager : MonoBehaviour
{
    #region List
    //Init of the GameObject List (maybe a private settings ? 03/10/2022)
    public List<GameObject> objectList;
    #endregion

    #region Transform
    //Init of spawner transform (maybe a private settings ? 03/10/2022)
    public Transform objectSpawner;
    #endregion

    public void Start()
    {
        //Fetch the gameobject prefab in a certain directory of the gameasset on this pattern Ressources / Prefab
        objectList = new List<GameObject>(Resources.LoadAll<GameObject>("Prefab"));
    }

    #region Color declare
    /// <summary> Color declare 
    /// This is the list of script for the prefab changing.
    /// This work with tag detection and spawn with spawn parameter. 2 object with 2 differents parameters. (for the moment on 03/10/2022 Blue and Red)
    /// </summary>
    /// <param name="trigger"> reference to the script Trigger1</param>
    #region CUBE
    public void TriggerColorChangingCBLEU(Trigger trigger)
    {
        GameObject CubeBleu = (objectList.Find(x => x.tag == "CUBEROUGE")) as GameObject;
        Instantiate(CubeBleu, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CUBEBLEU"));
    }

    public void TriggerColorChangingCRED(Trigger trigger1)
    {
        GameObject CubeROUGE = (objectList.Find(x => x.tag == "CUBEBLEU")) as GameObject;
        Instantiate(CubeROUGE, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CUBEROUGE"));
    }
    #endregion

    #region BALLE
    public void TriggerColorChangingBBLEU(Trigger trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "BALLEROUGE")) as GameObject;
        Instantiate(BalleBleu, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("BALLEBLEU"));
    }

    public void TriggerColorChangingBRED(Trigger trigger)
    {
        GameObject BalleRouge = (objectList.Find(x => x.tag == "BALLEBLEU")) as GameObject;
        Instantiate(BalleRouge, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("BALLEROUGE"));
    }
    #endregion
    #region CYLINDRE
    public void TriggerColorChangingCYBLEU(Trigger trigger)
    {
        GameObject CylindreBleu = (objectList.Find(x => x.tag == "CYLINDREROUGE")) as GameObject;
        Instantiate(CylindreBleu, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CYLINDREBLEU"));
    }

    public void TriggerColorChangingCYRED(Trigger trigger)
    {
        GameObject CylindreROUGE = (objectList.Find(x => x.tag == "CYLINDREBLEU")) as GameObject;
        Instantiate(CylindreROUGE, objectSpawner.transform.position, objectSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CYLINDREROUGE"));
    }
    #endregion
    #endregion
}
