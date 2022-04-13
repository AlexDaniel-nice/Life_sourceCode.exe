using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks_of_code : MonoBehaviour
{
    private void OnMouseDown()
    {
        Instantiate(GameAssets.GetInstance.buton_if);
    }
}
