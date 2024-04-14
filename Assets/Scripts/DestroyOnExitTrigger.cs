using UnityEngine;

public class DestroyOnExitTrigger : MonoBehaviour
{
    public string _triggerTag = string.Empty;
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(_triggerTag))
            Destroy(gameObject);
    }
}
