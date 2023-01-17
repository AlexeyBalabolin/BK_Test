using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="GameContent", menuName ="Configs/GameConfigs")]
public class GameConfigs : ScriptableObject
{
    public GameObject MenuPrefab;
    public List<PrimitiveType> PrimitiveTypes = new List<PrimitiveType>();
    public Material SelectedMaterial, DeselectedMaterial;
}
