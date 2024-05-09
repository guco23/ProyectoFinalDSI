using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class AsignBasicData : MonoBehaviour
{
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;

    //La pantalla principal mostrada ahora mismo
    [SerializeField]
    int currentMainScreen; // del 0 al 4

    VisualElement[] mainScreenBarElement;

    private void Start()
    {
        mainScreenBarElement = new VisualElement[5];

        doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        topBar = root.Q("topBar");

        SetUpBasicElems();
    }

    private void Update()
    {
        
    }

    void ChangeScreen(int sceneNum)
    {
        // Asegúrate de que el índice de la escena esté dentro del rango
        if (sceneNum >= 0 && sceneNum < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log(sceneNum);
            SceneManager.LoadScene(sceneNum);
        }
        else
        {
            Debug.LogError("Índice de escena fuera de rango.");
        }
    }

    //Crea la barra superior y otros elementos basicos que estar�n en pantalla
    void SetUpBasicElems()
    {
        Debug.Log("SetUpBasicElems");

        //Establece los MainScreenElements
        mainScreenBarElement[0] = topBar.Q("pestanaStat");
        Button boton1 = mainScreenBarElement[0].Q<Button>("Button");
        boton1.text = "STAT";
        boton1.RegisterCallback<MouseUpEvent>((evt) => {
            ChangeScreen(0);
        });

        mainScreenBarElement[1] = topBar.Q("pestanaInv");
        Button boton2 = mainScreenBarElement[1].Q<Button>("Button");
        boton2.text = "INV";
        boton2.RegisterCallback<MouseUpEvent>((evt2) => {
            ChangeScreen(1);
        });

        mainScreenBarElement[2] = topBar.Q("pestanaData");
        Button boton3 = mainScreenBarElement[2].Q<Button>("Button");
        boton3.text = "DATA";
        boton3.RegisterCallback<MouseUpEvent>((evt3) => {
            ChangeScreen(2);
        });

        mainScreenBarElement[3] = topBar.Q("pestanaMap");
        Button boton4 = mainScreenBarElement[3].Q<Button>("Button");
        boton4.text = "MAP";
        boton4.RegisterCallback<MouseUpEvent>((evt4) => {
            ChangeScreen(3);
        });

        mainScreenBarElement[4] = topBar.Q("pestanaRadio");
        Button boton5 = mainScreenBarElement[4].Q<Button>("Button");
        boton5.text = "RADIO";
        boton5.RegisterCallback<MouseUpEvent>((evt5) => {
            ChangeScreen(4);
        });

        mainScreenBarElement[currentMainScreen].Q("pestana").AddToClassList("highlighted");
    }
}
