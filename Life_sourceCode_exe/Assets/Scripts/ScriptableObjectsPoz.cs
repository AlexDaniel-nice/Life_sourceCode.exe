using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pozition_Container" , menuName = "ScriptableObjects/Pozition_Containers")]
public class ScriptableObjectsPoz : ScriptableObject
{
    public Transform OriginalPoz;
    public Transform TopViewPoz;
    public Transform CodeViewPoz;
}
