using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    [SerializeField]
    private float TimeToSpawnFriend;

    void Start()
    {
        SpawnFriend(10, 10, 10);
        SpawnFriend(10, 5, 5);
        SpawnFriend(-10, 10, 10);
    }

    private void SpawnFriend(float xPoz, float yPoz, float zPoz)
    {
        GameObject FriendEntity = Instantiate(GameAssets.GetInstance.Friend);
        FriendEntity.transform.position = new Vector3(xPoz, yPoz, zPoz);
    }

    //de gasit o metoda mai optima pt codul din update
    //de reparat functia timer
    private void Update()
    {
        float Timer = TimeToSpawnFriend;

        Timer -= Time.deltaTime;
        if (Timer<=0)
        {
            Timer = TimeToSpawnFriend;

            //In loc de 0 pun o functie care calculeaza o valoare random pt pozitia obiectului
           // SpawnFriend(0, 10, 0);
        }

    }
    private void TimeForNewFriend(float nextFriendInNsec)
    {
        
    }

}
