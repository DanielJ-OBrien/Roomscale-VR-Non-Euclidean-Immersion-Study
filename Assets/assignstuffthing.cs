using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class assignstuffthing : MonoBehaviour
{

    newscript help;
    private void Start()
    {
    }

    public void doTheThing(int a)
    {
        // Find the gameManager GameObject
        GameObject gameManager = GameObject.Find("gameManager");
        help = gameManager.GetComponent<newscript>();
        help.SwitchScene(a);
    }

}
