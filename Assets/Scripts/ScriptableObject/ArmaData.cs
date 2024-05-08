using UnityEngine;

[CreateAssetMenu(menuName = "arma")]
public class ArmaData : ScriptableObject
{
    [SerializeField]
    string name;
    [SerializeField]
    int str;
    [SerializeField]
    int dps;
    [SerializeField]
    float wg;
    [SerializeField]
    int val;
    [SerializeField]
    int cnd;
    [SerializeField]
    string ammo;
}
