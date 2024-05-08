using UnityEngine;
using UnityEngine.UIElements;

public class AsignBasicData : MonoBehaviour
{
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;
    
    //La pantalla principal mostrada ahora mismo
    int currentMainScreen;
    VisualElement[] mainScreenBarElement;

    void Start()
    {
        mainScreenBarElement = new VisualElement[5];
        doc = GetComponent<UIDocument>();
        currentMainScreen = 0;
    }

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        topBar = root.Q("topBar");

        SetUpBasicElems();
    }

    //Crea la barra superior y otros elementos basicos que estarán en pantalla
    void SetUpBasicElems()
    {
        //Establece los MainScreenElements
        //No entiendo los enum lol
        mainScreenBarElement[0] = topBar.Q("pestanaStat");
        mainScreenBarElement[1] = topBar.Q("pestanaInv");
        mainScreenBarElement[2] = topBar.Q("pestanaData");
        mainScreenBarElement[3] = topBar.Q("pestanaMap");
        mainScreenBarElement[4] = topBar.Q("pestanaRadio");
        mainScreenBarElement[currentMainScreen].AddToClassList("highlighted");
    }
}
