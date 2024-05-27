using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class DotSelector : MonoBehaviour, ISelector
{
    [SerializeField] string selectableTag = "Selectable";
    public List<SelectableText> selectable;
    public float threshhold;
    private Transform _selection;

    public void Check(Ray ray)
    {
        _selection = null;
        var closest = 0f;
        for (int i = 0; i < selectable.Count; i++)
        {
            Vector3 vector1 = ray.direction;
            Vector3 vector2 = selectable[i].transform.position - ray.origin;

            float lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized);


            selectable[i].LookPercent = lookPercentage;
            if (lookPercentage > threshhold && lookPercentage > closest)
            {
                closest = lookPercentage;
                _selection = selectable[i].transform;
            }
        }
    }
    public Transform GetSelection()
    {
        return _selection;
    }
}
