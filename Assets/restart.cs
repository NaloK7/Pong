using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            Time.timeScale = 1;
            Retry();
        }
    }

    
    private void Retry()
    {
        //Restarts current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    


}