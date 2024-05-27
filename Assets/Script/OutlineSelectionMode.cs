using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineSelectionMode : MonoBehaviour, ISelectionMode
{
    public void OnSelect(Transform Selection)
    {
        Outline outline = Selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 10;
        }
    }
    public void OnDeselect(Transform Selection)
    {
        Outline outline = Selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 0;
        }
    } 
}
