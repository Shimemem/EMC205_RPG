using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectableText : MonoBehaviour
{
    public TextMeshProUGUI lookPercentText;
    public float LookPercent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookPercentText.text = LookPercent.ToString("F3");
    }
}
