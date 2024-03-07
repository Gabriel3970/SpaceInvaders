using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed = 0.1f;
  public GameObject bullet;
  public Transform shottingOffset;
  

  // void Start()
  // {
  //   Enemy.OnEnemyDied += EnemyOnOnEnemyDied;
    
  // }

  // void OnDestroy()
  // {
  //   Enemy.OnEnemyDied -= EnemyOnOnEnemyDied;
  // }

  // void EnemyOnOnEnemyDied(int pointworth)
  // {
  //     Debug.Log($"player recieved 'Enemy Died' worth {pointworth}");
  // }

  // Update is called once per frame
  void Update()
  {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GetComponent<Animator>().SetTrigger("Shoot Trigger");

        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }

      if(Input.GetKey(KeyCode.LeftArrow))
      {
        this.transform.Translate(Vector3.up * speed);
      }

      if(Input.GetKey(KeyCode.RightArrow))
      {
        this.transform.Translate(Vector3.down * speed);
      }
  }
}
