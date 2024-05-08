using UnityEngine;

[CreateAssetMenu(menuName = "mision")]
public class MisionData : ScriptableObject
{
    [SerializeField]
    string nombre;
    [SerializeField]
    string descripcion;
}