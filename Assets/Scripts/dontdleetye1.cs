using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdleetye1 : MonoBehaviour
{

    public static dontdleetye1 instance; // Singleton instance
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep the GameManager object alive when loading new scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate GameManager objects
        }
    }
}
