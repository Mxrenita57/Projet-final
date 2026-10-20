using UnityEngine;
using StarterAssets;

[DefaultExecutionOrder(-100)]
public class Controles25D : MonoBehaviour
{
    StarterAssetsInputs input;
    void Start() { 
        input = GetComponent<StarterAssetsInputs>(); 
    }

    void Update() { 
        input.move.y = 0; 
    }
}