using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemmy_behaviour : MonoBehaviour
{
    public bool isFriend;

    // Start is called before the first frame update
    void Start()
    {
        body(isFriend, 0, 0);
        body(isFriend, 0, 10);
        body(isFriend, 10, 0);
    }

    private void body(bool isNotEnemy, float x, float y)
    {
        Transform Friend = Instantiate(assets.instance().Friend);
        Friend.position = new Vector3(x, y, 0);
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
