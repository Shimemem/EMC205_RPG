using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    IRaycastProvider irayProvider;
    ISelector iSelector;
    ISelectionMode iSelectionMode;

    private Transform currentSelection;

    private void Awake()
    {
        irayProvider = GetComponent<IRaycastProvider>();
        iSelector = GetComponent<ISelector>();
        iSelectionMode = GetComponent<ISelectionMode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSelection != null)
            iSelectionMode.OnDeselect(currentSelection);
        iSelector.Check(irayProvider.CreateRay());
        currentSelection = iSelector.GetSelection();

        if (currentSelection != null)
            iSelectionMode.OnSelect(currentSelection);
    }
}
