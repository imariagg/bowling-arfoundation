using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgain : MonoBehaviour
{

    [SerializeField]
    GameObject ball;

    public void Spawn()
    {
        Destroy(ball, 0.1f);
        Instantiate(ball, new Vector3(0f,0f,1.090003f), Quaternion.identity);
        ball.gameObject.transform.localScale = new Vector3(0.075f, 0.075f, 0.075f);
    }
}
