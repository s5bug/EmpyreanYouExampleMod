using System;
using UnityEngine;

namespace EmpyreanYouExampleMod.Components;

public class SizeOscillator : MonoBehaviour {
    private float timeLoop = 0.0f;
    private void Update() {
        timeLoop += Time.deltaTime;
        timeLoop %= 2 * Mathf.PI;
        
        float sin = Mathf.Sin(timeLoop);
        float scale = 1 + sin / 2;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
