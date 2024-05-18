using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetobrown : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    void Start()
    {
        player = GameObject.Find("XR Origin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene(int test)
    {
        player.transform.position = new Vector3(0, 0, 0);
    }
}
