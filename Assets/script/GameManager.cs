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
    private Vector3 size = new Vector3(0.2f, 0.2f, 0.2f);
    #region List
    //Init of the GameObject List (maybe a private settings ? 03/10/2022)
    public List<GameObject> objectList;
    #endregion

    #region Transform
    //Init of spawner transform (maybe a private settings ? 03/10/2022)
    public Transform objectChangerColorSpawner;
    public Transform objectNoColorChangingSpawner;
    public Transform objectSizeMoinsSpawner;
    #endregion

    private GameObject  cloneBB;

    public void Start()
    {
        //Fetch the gameobject prefab in a certain directory of the gameasset on this pattern Ressources / Prefab
        objectList = new List<GameObject>(Resources.LoadAll<GameObject>("Prefab"));
    }

    #region Color Changing declare
    /// <summary> Color declare 
    /// This is the list of script for the prefab changing.
    /// This work with tag detection and spawn with spawn parameter. 2 object with 2 differents parameters. (for the moment on 03/10/2022 Blue and Red)
    /// </summary>
    /// <param name="trigger"> reference to the init of trigger method</param>
    #region CUBE
    public void TriggerColorChangingCBLUE(TriggerChangingColor trigger)
    {
        GameObject CubeBleu = (objectList.Find(x => x.tag == "CUBEROUGE")) as GameObject;
        Instantiate(CubeBleu, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CUBEBLEU"));
    }

    public void TriggerColorChangingCRED(TriggerChangingColor trigger1)
    {
        GameObject CubeROUGE = (objectList.Find(x => x.tag == "CUBEBLEU")) as GameObject;
        Instantiate(CubeROUGE, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CUBEROUGE"));
    }
    #endregion

    #region BALLE
    public void TriggerColorChangingBBLUE(TriggerChangingColor trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "BALLEROUGE")) as GameObject;
        Instantiate(BalleBleu, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("BALLEBLEU"));
    }

    public void TriggerColorChangingBRED(TriggerChangingColor trigger)
    {
        GameObject BalleRouge = (objectList.Find(x => x.tag == "BALLEBLEU")) as GameObject;
        Instantiate(BalleRouge, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("BALLEROUGE"));
    }
    #endregion
    #region CYLINDRE
    public void TriggerColorChangingCYBLUE(TriggerChangingColor trigger)
    {
        GameObject CylindreBleu = (objectList.Find(x => x.tag == "CYLINDREROUGE")) as GameObject;
        Instantiate(CylindreBleu, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CYLINDREBLEU"));
    }

    public void TriggerColorChangingCYRED(TriggerChangingColor trigger)
    {
        GameObject CylindreROUGE = (objectList.Find(x => x.tag == "CYLINDREBLEU")) as GameObject;
        Instantiate(CylindreROUGE, objectChangerColorSpawner.transform.position, objectChangerColorSpawner.transform.rotation);
        Destroy(GameObject.FindWithTag("CYLINDREROUGE"));
    }
    #endregion
    #endregion

    /// <summary> No Changing Color
    /// This is the list of script for the spawning of no changing prefab.
    /// This work with tag detection and spawn the exact same object with the exact same references
    /// </summary>
    /// <param name="trigger"> reference to the init of trigger method</param>
    #region CUBE
    public void TriggerNoChangingCBLUE(TriggerNochanging trigger)
    {
        GameObject CubeBleu = (objectList.Find(x => x.tag == "CUBEBLEU")) as GameObject;
        Instantiate(CubeBleu, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("CUBEBLEU"));
    }

    public void TriggerNoChangingCRED(TriggerNochanging trigger)
    {
        GameObject CubeRouge = (objectList.Find(x => x.tag == "CUBEROUGE")) as GameObject;
        Instantiate(CubeRouge, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("CUBEROUGE"));
    }
    #endregion
    #region BALLE
    public void TriggerNoChangingBBLUE(TriggerNochanging trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "BALLEBLEU")) as GameObject;
        Instantiate(BalleBleu, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("BALLEBLEU"));
    }
    public void TriggerNoChangingBRED(TriggerNochanging trigger)
    {
        GameObject BalleRouge = (objectList.Find(x => x.tag == "BALLEROUGE")) as GameObject;
        Instantiate(BalleRouge, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("BALLEROUGE"));
    }
    #endregion
    #region CYLINDRE
    public void TriggerNoChangingCYBLUE(TriggerNochanging trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "CYLINDREBLEU")) as GameObject;
        Instantiate(BalleBleu, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("CYLINDREBLEU"));
    }
    public void TriggerNoChangingCYRED(TriggerNochanging trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "CYLINDREROUGE")) as GameObject;
        Instantiate(BalleBleu, objectNoColorChangingSpawner.transform.position, objectNoColorChangingSpawner.transform.rotation);
        Destroy(GameObject.Find("CYLINDREROUGE"));
    }
    #endregion

    public void TriggerSizeChangingMoinsBBleu(TriggerChangingSizeMoins trigger)
    {
        GameObject BalleBleu = (objectList.Find(x => x.tag == "BALLEBLEU")) as GameObject;
        Instantiate(BalleBleu, objectSizeMoinsSpawner.transform.position, objectSizeMoinsSpawner.transform.rotation);
        BalleBleu.transform.localScale = BalleBleu.transform.localScale - size;
        //BalleBleu.transform.localScale += new Vector3(-0.2f, -0.2f, -0.2f);
        Destroy(GameObject.Find("BALLEBLEU"));
    }
}




