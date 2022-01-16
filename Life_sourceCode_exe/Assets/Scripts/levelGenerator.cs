using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    [SerializeField] private float TimeToSpawnFriend;

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

    private float RandomCoordonates_Friend(float xPozition, float yPozition, float zPozition)
    {
        return 0;
    }

    //s-ar putea sa nu mearga
    private void TimeBetweenFrinds(float time)
    {
        float Timer = time;

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = TimeToSpawnFriend;

            //In loc de 0 pun o functie care calculeaza o valoare random pt pozitia obiectului
            // SpawnFriend(0, 10, 0);
        }
    }
    //de gasit o metoda mai optima pt codul din update
    //de reparat functia timer
    private void Update()
    {
        TimeBetweenFrinds(TimeToSpawnFriend);

    }

    //ori functia asta ori TimeBetweenFrinds(...)
    private void TimeForNewFriend(float nextFriendInNsec)
    {
        
    }

}
