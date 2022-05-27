using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    [SerializeField] private float TimeToSpawnFriend = 1;

    private float Timer = 0;


    void Start()
    {
       
    }

    private void SpawnFriend()
    {
        GameObject FriendEntity = Instantiate(GameAssets.GetInstance.Friend);

        float xPoz = Random.Range(-15, 15);
        float zPoz = Random.Range(-15, 15);
        float yPoz = Random.Range(5, 15);
        
        FriendEntity.transform.position = new Vector3(xPoz, yPoz, zPoz);
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= TimeToSpawnFriend)
        {
            SpawnFriend();
            Timer = 0;
        }
    }
}
