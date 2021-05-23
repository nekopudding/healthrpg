using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    public Enemy enemy;
    public Player player;
    // Start is called before the first frame update
    public Combat(Enemy enemy, Player player)
    {
        this.enemy = enemy;
        this.player = player;

        StartCoroutine(Turns());
    }


    public IEnumerator Turns()
    {
        int playerAtk = ((player.maxMana - 100) + 1) * 2;
        while (player.currentHealth > 0 && enemy.hp > 0)
        {
            if (player.currentMana > 0)
            {
                enemy.TakeDamage(playerAtk);
                player.DrainMana(10);
            }

            player.TakeDamage(enemy.dmg);
            if (enemy.hp <= 0 || player.currentHealth <= 0)
            {
                player.SavePlayer();
                SceneManager.LoadScene("Explore");
                break;
            }
            yield return new WaitForSeconds(1);
        }

    }


}
