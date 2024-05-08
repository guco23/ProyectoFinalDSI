using UnityEditor.UIElements;
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

    private void OnEnable()
    {
        mainScreenBarElement = new VisualElement[5];
        currentMainScreen = 0;

        doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        topBar = root.Q("topBar");

        SetUpBasicElems();
    }

    //Crea la barra superior y otros elementos basicos que estar�n en pantalla
    void SetUpBasicElems()
    {
        //Establece los MainScreenElements
        mainScreenBarElement[0] = topBar.Q("pestanaStat");
        mainScreenBarElement[0].Q<Label>("texto").text = "DATA";
        mainScreenBarElement[1] = topBar.Q("pestanaInv");
        mainScreenBarElement[1].Q<Label>("texto").text = "INV";
        mainScreenBarElement[2] = topBar.Q("pestanaData");
        mainScreenBarElement[2].Q<Label>("texto").text = "DATA";
        mainScreenBarElement[3] = topBar.Q("pestanaMap");
        mainScreenBarElement[3].Q<Label>("texto").text = "MAP";
        mainScreenBarElement[4] = topBar.Q("pestanaRadio");
        mainScreenBarElement[4].Q<Label>("texto").text = "RADIO";
        mainScreenBarElement[currentMainScreen].Q("pestana").AddToClassList("highlighted");
    }
}
