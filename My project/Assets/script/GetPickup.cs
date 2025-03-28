
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer r;
    private AudioSource source;
    private ParticleSystem ps;
    private KeepScore scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        scoreScript = FindObjectOfType<KeepScore>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("sdfghj");
        if (other.gameObject.CompareTag("Player")) { 

            Debug.Log("jhgf");
            r.enabled = false;
            GameObject.Destroy(gameObject, 20f);
            source.Play();
            ps.Play();
            scoreScript.AddScore(5);

        }
    }

 
}
