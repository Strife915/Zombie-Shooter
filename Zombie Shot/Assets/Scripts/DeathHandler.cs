using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gamerOverCanvas;

    private void Start()
    {
        gamerOverCanvas.enabled = false;
    }
    public void HandleDeath()
    {
        gamerOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
