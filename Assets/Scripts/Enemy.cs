using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points = 3;
    public int id = 1;
    public delegate void EnemyDied(int pointworth);
    // public static event EnemyDied OnEnemyDied;
    public ScoreManager scoreManager;

    void destroyEnemy()
    {
      // OnEnemyDied.Invoke(points);
      Destroy(gameObject);
      scoreManager.OnScore(id);
    }

    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collision)
    {
      GetComponent<Animator>().SetTrigger("Enemy Death");
      

      Debug.Log("Ouch!");
      Destroy(collision.gameObject);
    }


}
