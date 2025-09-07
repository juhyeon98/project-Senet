using UnityEngine;

[CreateAssetMenu(fileName = "Stat Data", menuName = "Scriptable Objects/Stat")]
public class StatDataSO : ScriptableObject
{
    #region Description
    [Header("Description")]
    public string name;
    public string description;
    #endregion

    #region Field
    [Header("Field")]
    [Range(0, 100)] public float HP;
    [Range(0, 100)] public float ATK;
    [Range(0, 100)] public int MOV;
    [Range(0, 100)] public int AP;
    #endregion
}
