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

        if(transform.position.y <= -10.1)
        {
            transform.position = new Vector3(transform.position.x, 10.1f, 0);
        }
    }
}
