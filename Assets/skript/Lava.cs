using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] private GameObject BallPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Instantiate(BallPlayer);
        BallPlayer.transform.position = new Vector2(9.62f, 7.46f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
