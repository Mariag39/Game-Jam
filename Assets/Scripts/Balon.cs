using UnityEngine;

public class Balon : MonoBehaviour {
    // Start is called before the first frame update
    public float m_MaxLifeTime = 4f;



    private void Start()
    {
        // If it isn't destroyed by then, destroy the shell after it's lifetime.
        Destroy(gameObject, m_MaxLifeTime);
    }

    // Update is called once per frame
    void Update() {
       
    }
   

}
