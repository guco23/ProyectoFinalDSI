using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AsignBasicData : MonoBehaviour
{
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;

    void Start()
    {
        doc = GetComponent<UIDocument>();
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        topBar = root.Q("topBar");
    }
}
