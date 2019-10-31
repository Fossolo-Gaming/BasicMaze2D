using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour
{
    public string NextLevelName = "Level2";

    public GameObject finalMessage = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("level1");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (finalMessage != null)
            {
                finalMessage.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(NextLevelName); // loads scene When player enter the trigger collider
            }
        }
    }
}
