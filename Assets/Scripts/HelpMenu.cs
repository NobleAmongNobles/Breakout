using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour
{

    public GameObject PanelSingleplayerControls;
    public GameObject PanelMultiplayerControls;
    public GameObject PanelItems;

    // Start is called before the first frame update
    void Start()
    {
        //PanelSingleplayerControls = GameObject.Find("PanelSingleplayerControls");
        //PanelMultiplayerControls = GameObject.Find("PanelMultiplayerControls");
        //PanelItems = GameObject.Find("PanelItems");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonSingleplayerControls(){
        PanelItems.SetActive(false);
        PanelMultiplayerControls.SetActive(false);
        PanelSingleplayerControls.SetActive(true);
    }

    public void ButtonMultiplayerControls(){
        PanelSingleplayerControls.SetActive(false);
        PanelItems.SetActive(false);
        PanelMultiplayerControls.SetActive(true);
    }

    public void ButtonItems(){
        PanelSingleplayerControls.SetActive(false);
        PanelMultiplayerControls.SetActive(false);
        PanelItems.SetActive(true);
    }

    public void Back(){
        SceneManager.LoadScene(0);
    }
}
