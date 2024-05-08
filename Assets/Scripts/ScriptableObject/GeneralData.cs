using UnityEngine;

[CreateAssetMenu(menuName = "general")]
public class GeneralData : ScriptableObject
{
    [SerializeField]
    string hp;
    [SerializeField]
    int level;
    [SerializeField]
    string ap;
    [SerializeField]
    string peso;
    [SerializeField]
    int chapas;
    [SerializeField]
    string ubicacion;
    [SerializeField]
    string fecha;
    [SerializeField]
    string hora;
}
