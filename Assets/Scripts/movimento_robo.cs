using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento_robo : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rigidBodyRobo;
    private bool MotorImpressora;
    private bool MotorDvd;

    void Start()
    {
        MotorImpressora = false;
        MotorDvd = false;
        rigidBodyRobo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if(MotorDvd == true){

            rigidBodyRobo.AddForce(0, 0, 12, ForceMode.Acceleration);

        }else if(MotorImpressora == true){

            rigidBodyRobo.AddForce(0, 0, 30, ForceMode.Acceleration);

        }
        
    }

    public void acionaMotorDvd(){
        if(MotorDvd == true){
            MotorDvd = false;
        } else {
            MotorDvd = true;
        }

        if(MotorImpressora == true){
            MotorImpressora = false;
        }
        
    }

    public void acionaMotorImpressora(){
        if(MotorImpressora == true){
            MotorImpressora = false;
        } else {
            MotorImpressora = true;
        }

        if(MotorDvd == true){
            MotorDvd = false;
        }
    }

    public void desliga(){
        if(MotorImpressora == true){
            MotorImpressora = false;
        }else if(MotorDvd == true) {
            MotorDvd = false;
        }
    }

}
