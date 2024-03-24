using UnityEngine;

public class basketballsystem : MonoBehaviour
{
    [SerializeField]
    private GameObject basketball;

    // 哈摟

    public void SpawnBasketball() 
    {
        Instantiate(basketball, transform.position, Quaternion.identity);
    }
}
