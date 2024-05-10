using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Data : MonoBehaviour
{
    GeneralData generalData;
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;
    VisualElement lowerBar;

    private void OnEnable()
    {
        generalData = Resources.Load<GeneralData>("ScriptableObjects/general");
        doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        topBar = root.Q("topBar");
        lowerBar = root.Q("lowerBar");
        SetUpBasicElems();
    }

    //Crea la barra superior y otros elementos basicos que estar�n en pantalla
    void SetUpBasicElems()
    {
        //Establece la barra slider de arriba
        topBar.Q("pestana1").Q<Label>("texto").text = "STATUS";
        topBar.Q("pestana2").Q<Label>("texto").text = "SPECIAL";
        topBar.Q("pestana3").Q<Label>("texto").text = "PERKS";
        topBar.Q("pestana4").Q<Label>("texto").text = "";
        //Establece las datas de la barra de abajo
        lowerBar.Q<VisualElement>("Elemento1").Q<Label>("tipo").text = "HP";
        lowerBar.Q<VisualElement>("Elemento1").Q<Label>("data").text = generalData.hp;
        lowerBar.Q<VisualElement>("Elemento3").Q<Label>("tipo").text = "AP";
        lowerBar.Q<VisualElement>("Elemento3").Q<Label>("data").text = generalData.ap;
        lowerBar.Q<VisualElement>("Elemento2").Q<Label>("tipo").text = generalData.level;


    }
}
