using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int scorereward;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Me"))
        {
            Debug.Log("touched");
            collected();
            
        }
    }

    private void collected()
    {
        GameManager.instance.UpdateCoin(scorereward);
        Destroy(this.gameObject);
    }

}
