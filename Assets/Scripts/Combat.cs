using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    public SampleEnemy enemy;
    public Player player;
    // Start is called before the first frame update


    public void Start()
    {
        Debug.Log("Battle start");
        StartCoroutine(Turns());
    }

    public IEnumerator Turns()
    {
        int playerAtk = (player.maxMana - 95) * 2;
        while (player.currentHealth > 0 && enemy.hp > 0)
        {
            Debug.Log(player.currentMana);
            if (player.currentMana > 0)
            {
                Debug.Log("Enemy takes damage");
                enemy.TakeDamage(playerAtk);
                player.DrainMana(10);
            }

            player.TakeDamage(enemy.dmg);
            if (enemy.hp <= 0 || player.currentHealth <= 0)
            {
                SceneManager.LoadScene("Explore");
                break;
            }
            yield return new WaitForSeconds(1);
        }

    }


}
