using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatilho : MonoBehaviour
{
    public movimento_robo robo;
    private void OnTriggerEnter(Collider colisor) {
        robo.desliga();
    }

}