using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendBehaviour : MonoBehaviour
{
    [SerializeField] private Transform HostPoz;
    [SerializeField] private float delay;
    [SerializeField] private float timeBeforeMove;

    
    private Transform startingPoz;
    private float ratio, Timer = 0;
    private bool move = false;
    private bool COLIDING = false;
    

    public bool GetColidingBool()
    {
        return COLIDING;
    }
    // Start is called before the first frame update
    void Start()
    {
        startingPoz = this.transform;
        ratio = 1 / delay;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ribozom") COLIDING = true;
        Destroy(this.gameObject);
    }
    private void MoveToFriend(float t)
    {
        this.transform.position = Vector3.Lerp(startingPoz.position,HostPoz.position, t);
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= timeBeforeMove)
        {
            move = true;
        }

        if (move == true)
            MoveToFriend(ratio);
    }
}
