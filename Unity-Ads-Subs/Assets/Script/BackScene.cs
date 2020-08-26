using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void ChangeSceneBack01()
    {

        SceneManager.LoadScene("Scene01");
        Debug.Log("Back to Menu");

    }
}
