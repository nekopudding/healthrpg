using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string scene = "Home";
    public Button btn;
    public Player player;
    void Start()
    {
        Debug.Log("Start adding listener to button");
        btn.onClick.AddListener(NextScene);
        Debug.Log("Added listener to button");
    }

    public void NextScene()
    {
        Debug.Log("Button clicked");
        player.SavePlayer();
        SceneManager.LoadScene(scene);
    }
}