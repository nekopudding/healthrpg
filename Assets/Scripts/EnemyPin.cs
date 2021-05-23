using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyPin : MonoBehaviour
{
    Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
       // gameObject.GetComponent<Button>().onClick.AddListener(NextScene);
    }

    // Update is called once per frame
    void NextScene()
    {
        GlobalControl.Instance.player.SavePlayer();
        Input.location.Stop();
        SceneManager.LoadScene("Battle");
        GlobalControl.Instance.currentEnemy = enemy;
    }
}
