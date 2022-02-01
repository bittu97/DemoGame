using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 OffSet;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        OffSet = transform.position - Player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.position + OffSet;
        transform.LookAt(Player);
    }
}
