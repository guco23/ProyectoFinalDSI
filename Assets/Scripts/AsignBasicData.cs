using UnityEngine;
using UnityEngine.UIElements;

public class AsignBasicData : MonoBehaviour
{
    UIDocument doc;
    VisualElement root;
    VisualElement topBar;
    
    //La pantalla principal mostrada ahora mismo
    MainScreen currentMainScreen;
    VisualElement[] mainScreenBarElement;

    enum MainScreen
    {
        STAT = 0,
        INV = 1,
        DATA = 2,
        MAP = 3,
        RADIO = 4
    }

    void Start()
    {
        mainScreenBarElement = new VisualElement[5];
        doc = GetComponent<UIDocument>();
        currentMainScreen = MainScreen.STAT;
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        topBar = root.Q("topBar");

        SetUpBasicElems();
    }

    //Crea la barra superior y otros elementos basicos que estarán en pantalla
    void SetUpBasicElems()
    {
        //Establece los MainScreenElements
        //No entiendo los enum lol
        mainScreenBarElement[] = topBar.Q("q");
    }
}
