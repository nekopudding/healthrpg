using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChangeScene : MonoBehaviour
{
    public string scene = "Home";
    public Button btn;
    public Player player;
    void Start()
    {
        //Debug.Log("Start adding listener to button");
        btn.onClick.AddListener(NextScene);
        //Debug.Log("Added listener to button");
    }

    public void NextScene()
    {
        //Debug.Log("Button clicked");
        GlobalControl.Instance.player.SavePlayer();
        GlobalControl.Instance.enemies = new List<Enemy>();
        Input.location.Stop();
        SceneManager.LoadScene(scene);
    }
}
