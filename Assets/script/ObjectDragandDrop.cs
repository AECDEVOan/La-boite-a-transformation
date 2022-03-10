using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary> Object Drag ans Drop
/// This script was created on 10/03/2022 by Oan COQUILLE for the project La boite a transformation
/// The purpose of this script is to drag and drop object with the mouse from anyware to the trigger area using world position and mouse position.
/// It Only work on the Y and X axis 
/// </summary>
public class ObjectDragandDrop : MonoBehaviour
{
    #region Vector3
    Vector3 offset;
    #endregion

    #region string
    public string destinationtag = "DropArea";
    #endregion

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationtag)
            {
                transform.position = hitInfo.transform.position;
            }
        }
        transform.GetComponent<Collider>().enabled = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
