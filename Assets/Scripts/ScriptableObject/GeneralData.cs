using UnityEngine;

[CreateAssetMenu(menuName = "general")]
public class GeneralData : ScriptableObject
{
    [SerializeField]
    public string hp;
    [SerializeField]
    public string level;
    [SerializeField]
    public string ap;
    [SerializeField]
    public string peso;
    [SerializeField]
    public int chapas;
    [SerializeField]
    public string ubicacion;
    [SerializeField]
    public string fecha;
    [SerializeField]
    public string hora;
}
