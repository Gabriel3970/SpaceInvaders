using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : MonoBehaviour
{
    public int points = 5;
    public int id = 2;
    public delegate void EnemyDied(int pointworth);
    // public event EnemyDied OnEnemyDied;
    public ScoreManager scoreManager;

    void destroyEnemy()
    {
      Destroy(gameObject);
      scoreManager.OnScore(id);
    }

    // Start is called before the first frame update
    void Start(){}

    void OnCollisionEnter2D(Collision2D collision)
    {
      GetComponent<Animator>().SetTrigger("Enemy Death");
      

      Debug.Log("Ouch!");
      Destroy(collision.gameObject);
    }


}

