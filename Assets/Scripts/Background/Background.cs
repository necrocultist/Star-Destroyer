using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Background : MonoBehaviour
{
    [SerializeField] private float backgroundSpeed;

    void Update()
    {
        transform.position += new Vector3(0, backgroundSpeed * Time.deltaTime, 0);

        if(transform.position.y <= -7)
        {
            transform.position = new Vector3(transform.position.x, 13, 0);
        }
    }
}
