using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class adtocunter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private newscript test;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bruh()
    {
        test = GameObject.Find("gameManager").GetComponent<newscript>();
        test.IncrementValue();
    }
}