﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Inv : MonoBehaviour
{
    //Datos
    ArmaData[] armaData;
    GeneralData generalData;

    //Elemntos generales
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;
    VisualElement lowerBar;
    //Elementos especificos de el funcionamiento de esta pantalla
    VisualElement listadoItems;
    UIDocument itemTemplate; //El item del listado base para copiar
    VisualElement[] items;

    private void Start()
    {
        generalData = Resources.Load<GeneralData>("ScriptableObjects/general");
        armaData = Resources.LoadAll<ArmaData>("ScriptableObjects/armas/");
        doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        topBar = root.Q("topBar");
        lowerBar = root.Q("lowerBar");
        listadoItems = root.Q("ListadoSeleccionables").Q("Listado");
        itemTemplate = Resources.Load<UIDocument>("UI/ListaSeleccionable");
        SetUpBasicElems();
        //SetUpItemList();
    }

    void AddHoverEffect(VisualElement buttonElement)
    {
        buttonElement.RegisterCallback<MouseEnterEvent>((evt) => {
            buttonElement.AddToClassList("highlighted");
        });
        buttonElement.RegisterCallback<MouseLeaveEvent>((evt) => {
            buttonElement.RemoveFromClassList("highlighted");
        });
    }

    //Crea la barra superior y otros elementos basicos que estar�n en pantalla
    void SetUpBasicElems()
    {
        //Establece los Highlights, esto se borraría de aquí si usasemos SetUpItemList ya al programar el juego de verdad
        foreach (var item in listadoItems.Children())
        {
            AddHoverEffect(item);
        }
        //Establece la barra slider de arriba
        topBar.Q("pestana1").Q<Label>("texto").text = "ARMAS";
        topBar.Q("pestana2").Q<Label>("texto").text = "ARMADURA";
        topBar.Q("pestana3").Q<Label>("texto").text = "AYUDA";
        topBar.Q("pestana4").Q<Label>("texto").text = "OTROS";
        //Establece las datas de la barra de abajo
        lowerBar.Q<VisualElement>("Elemento1").Q<Label>("tipo").text = "PESO";
        lowerBar.Q<VisualElement>("Elemento1").Q<Label>("data").text = generalData.peso;
        lowerBar.Q<VisualElement>("Elemento3").Q<Label>("tipo").text = "CHAPAS";
        lowerBar.Q<VisualElement>("Elemento3").Q<Label>("data").text = generalData.chapas.ToString();
        //En el elemento 3 poner el nombre del arma equipada
    }

    void SetUpItemList() // Posible aproximación si el juego estuviera programado
    {

        items = new VisualElement[armaData.Length];
        for(int i = 0; i < armaData.Length; i++)
        {
            //Crea una copia del elemento base list element y lo guarda en el array
            items[i] = itemTemplate.visualTreeAsset.CloneTree();

            //Lo añade al array
            listadoItems.Add(items[i]);

            // Agrega el efecto de resaltado al pasar el puntero sobre el elemento
            AddHoverEffect(items[i]);
        }
    }
}
