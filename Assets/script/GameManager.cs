using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> objectList;

    public Transform spawner0;

    public void Start()
    {
        objectList = new List<GameObject>(Resources.LoadAll<GameObject>("Prefab"));
    }
}
