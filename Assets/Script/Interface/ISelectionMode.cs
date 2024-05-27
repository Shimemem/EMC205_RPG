using UnityEngine;

internal interface ISelectionMode
{
    void OnSelect(Transform Selection);
    void OnDeselect(Transform Selection);
}
