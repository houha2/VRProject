using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerScript : MonoBehaviour
{
    public GameObject start, tutorial, quit;
    public int button_selected;
    Color unselected, selected;
    // Use this for initialization
    void Start()
    {
        button_selected = 0;
        unselected = new Color(0.20392156862f, 0.65882352941f, 0.32549019607f);//green
        selected = new Color(0.98431372549f, 0.73725490196f, 0.01960784313f); //yellow

    }

    // Update is called once per frame
    void Update()
    {
        //state 0 is start menu
            selection();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();
#endif
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                button_selected = (button_selected + 1) % 3;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                button_selected = (button_selected + 1) % 3;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                button_selected = (button_selected + 2) % 3;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                button_selected = (button_selected + 2) %3;
            }
            //selection();
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if(button_selected == 2)
                {
                    #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
                    #else
                        Application.Quit();
                    #endif
                }
                else
                {
                    SceneManager.LoadScene("Enviroment", LoadSceneMode.Single);
                }
            }   

    }

    void selection()
    {
        if (button_selected == 0)
        {
            start.GetComponent<Renderer>().material.color = selected;
        }
        else
        {
            start.GetComponent<Renderer>().material.color = unselected;
        }

        if (button_selected == 1)
        {
            tutorial.GetComponent<Renderer>().material.color = selected;
        }
        else
        {
            tutorial.GetComponent<Renderer>().material.color = unselected;
        }

        if (button_selected == 2)
        {
            quit.GetComponent<Renderer>().material.color = selected;
        }
        else
        {
            quit.GetComponent<Renderer>().material.color = unselected;
        }
    }
}
