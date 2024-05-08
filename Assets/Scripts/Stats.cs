using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stats : MonoBehaviour
{
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;

    private void OnEnable()
    {
        doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        topBar = root.Q("topBar");

        SetUpBasicElems();
    }

    //Crea la barra superior y otros elementos basicos que estar�n en pantalla
    void SetUpBasicElems()
    {
        //Establece los MainScreenElements
        topBar.Q("pestana1").Q<Label>("texto").text = "STATUS";
        topBar.Q("pestana2").Q<Label>("texto").text = "SPECIAL";
        topBar.Q("pestana3").Q<Label>("texto").text = "PERKS";
        topBar.Q("pestana4").Q<Label>("texto").text = "";
    }
}
