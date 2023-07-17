using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndMovementOfPALANCA : MonoBehaviour
{
    private float anglePivot;
    private bool checkForInitialPosition;
    private Transform elTransformDeLaPalanca;
    // Start is called before the first frame update
    void Start()
    {
        elTransformDeLaPalanca = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        ControlMovementAndRotation();
    }

    void ControlMovementAndRotation()
    {
        // Esta funcion es para controlar y forzar los angulos de la palanca exactamente como quiero.
        // El angulo de Y SIEMPRE debe ser 0.
        anglePivot = -elTransformDeLaPalanca.transform.eulerAngles.y;
        elTransformDeLaPalanca.Rotate(new Vector3(elTransformDeLaPalanca.transform.eulerAngles.x, (elTransformDeLaPalanca.transform.eulerAngles.y + anglePivot), elTransformDeLaPalanca.transform.eulerAngles.z));
        if(elTransformDeLaPalanca.transform.eulerAngles == Vector3.zero){
            // Esta funcion mira si estoy en la posicion inicial, o neutral. Y si lo estoy, espero a la funcion de Input de la mano de VR para que mueva la palanca.
            checkForInitialPosition = true;
            return;
        }
        if(elTransformDeLaPalanca.rotation.x != 0){
            anglePivot = -elTransformDeLaPalanca.transform.eulerAngles.z;
            elTransformDeLaPalanca.transform.Rotate(new Vector3 (elTransformDeLaPalanca.transform.eulerAngles.x, 0f, (elTransformDeLaPalanca.transform.eulerAngles.z + anglePivot)));
        }
    }


}
