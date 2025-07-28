using UnityEngine;

public class PortInteraction : MonoBehaviour
{
    private bool isNearPort = false;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("PORTS"))
        {
            isNearPort = true;
            Debug.Log("Near Port, press E to dock.");
        }
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("PORTS"))
        {
            isNearPort = false;
            Debug.Log("Left the Port");
        }
    }

    private void Update()
    {
        if (isNearPort && Input.GetKeyDown(KeyCode.E)) {
            DockAtPort();
        }
    }

    private void DockAtPort()
    {
        Debug.Log("Docked at port.");
    }
}
