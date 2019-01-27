using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    Door[] availableDoors;
    public List<Door> doors = new List<Door>();

    int totalDoors;


    private void Start()
    {
        availableDoors = GameObject.FindObjectsOfType<Door>();
        totalDoors = availableDoors.Length;


        foreach (Door door in availableDoors)
        {
            doors.Add(door);
        }

        for (int i = 0; i < totalDoors; i++)
        {
            if (doors[i].Equals(this))
            {
                doors.Remove(doors[i]);
            }
        }
        
    }

    public void TeleportPlayer(Player player)
    {

        player.transform.position = doors[Random.Range(0, doors.Capacity)].transform.position;
    }
}
