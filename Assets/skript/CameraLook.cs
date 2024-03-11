using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    [SerializeField] private Transform Player;
    [SerializeField] private float _speed;
    [SerializeField] private string playerTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.Player)
        {
            Vector3 target = new Vector3(this.Player.position.x, this.Player.position.y, this.Player.position.z - 10);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, _speed * Time.deltaTime);
            this.transform.position = pos;
        }
        else
            this.Player = GameObject.FindGameObjectWithTag(this.playerTag).transform;

    }
}
