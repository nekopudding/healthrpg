using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string scene = "Home";
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(NextScene);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(scene);
    }
}