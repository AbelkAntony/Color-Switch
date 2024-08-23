
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;

    private void Update()
    {
        if(player.position.y > this.transform.position.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, player.position.y, this.transform.position.z);
        }
    }
}
