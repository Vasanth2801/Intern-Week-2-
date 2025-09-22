using Unity.Cinemachine;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    [SerializeField] private Animator enemyAnimations;     //Reference for the animator we have created for playing the animations(Enemy)
    [SerializeField] private float moveSpeed = 2f;              // Enemy movement speed
    [SerializeField] private GameObject target;                  // Target for the enemy to follow

    //Start calls at first frame of the game
    private void Start()
    {
        if(target == null)          //if the there is no target assigned in the inspector, it will find the player by tag
        {
            target = GameObject.FindGameObjectWithTag("Player");           //find the player tag gameobject
        } 
    }


    // called every frame
    private void Update()
    {
        FollowTarget();       // method to follow the target
    }


    // for following the target
    void FollowTarget()
    {
        if(target != null)            // if there is a target assigned
        {
            Vector2 direction = target.transform.position - transform.position;      // minus the enemy position from the target position to get the direction
            transform.Translate(direction*moveSpeed*Time.deltaTime);                  // move the enemy towards the target with the given speed
            // for flipping the enemy based on movement direction
            if (direction.x > 0)
                transform.localScale = new Vector3(1, 1, 1);   //Facing Right
            else if (direction.x < 0)
                transform.localScale = new Vector3(-1, 1, 1);  //Facing Left
        }
    }

}
