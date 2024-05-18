using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class newscript : MonoBehaviour
{
    public static newscript instance; // Singleton instance

    public int value = 0; // Value to track

    public GameObject player;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep the GameManager object alive when loading new scenes
            player = GameObject.Find("XR Origin");
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate GameManager objects
        }
    }

    public void IncrementValue()
    {
        value++; // Increment the value

        if (value >= 5)
        {
            value = 0;
            SwitchScene(0); // Switch scene if the value reaches 5
        }
    }

    public void SwitchScene(int test)
    {
        if(test==0){
            SceneManager.LoadScene("0"); 
            player.transform.position = new Vector3(0, 1, 4);
        }
        if(test==1){SceneManager.LoadScene("1"); player.transform.position = new Vector3(0, 0, 0);}
        if(test==2){SceneManager.LoadScene("2"); player.transform.position = new Vector3(0, 0, 0);}
        if(test==3){SceneManager.LoadScene("3"); player.transform.position = new Vector3(0, 0, 0);}
    }

    private void OnSceneLoaded(AsyncOperation asyncOperation)
    {
        // Scene has finished loading, you can now display it
        Debug.Log("Scene loaded successfully!");
    }

}
