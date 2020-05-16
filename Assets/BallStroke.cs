using UnityEngine;

public class BallStroke : MonoBehaviour
{

    public Rigidbody rb;

    //alles hängt von der Länge des Mausklicks ab

    // dieser Mausklick muss dann die Kraft auf den Ball übertragen, damit er sich nach vorne bewegt.

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 500);
    }

}
