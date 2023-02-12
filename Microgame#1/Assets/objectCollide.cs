using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCollide : MonoBehaviour
{
    public EgamMicrogameInstance microgameInstance;
    public EgamMicrogameHelper egamMicrogameHelper;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stick")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            egamMicrogameHelper.instance._timeoutType = EgamMicrogameHelper.WinLose.Win;
            egamMicrogameHelper.instance._duration = 0;

        }
    }
    public void OnWinCondition()
    {
        microgameInstance.WinGame();
    }
}
