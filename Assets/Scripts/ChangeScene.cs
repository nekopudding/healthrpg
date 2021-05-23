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
        
        btn.onClick.AddListener(NextScene);
    }

    public void NextScene()
    {

        player.SavePlayer();
        SceneManager.LoadScene(scene);
    }
}