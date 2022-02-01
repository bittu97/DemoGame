using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfoManager : MonoBehaviour
{
    public Text InfoText;
    public Transform Player;
    public Transform Enemy1, Enemy2, Enemy3;
    // Start is called before the first frame update
    void Start()
    {
        InfoText.text = "Game Starts";
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Enemy1.position, Player.position) < 2f || Vector3.Distance(Enemy2.position, Player.position) < 2f || Vector3.Distance(Enemy3.position, Player.position) < 2f)
        {
            InfoText.text = "Danger Zone";
            InfoText.color = Color.red;
        }
        else
        {
            InfoText.text = "Safe";
            InfoText.color = Color.green;
        }
    }
}
