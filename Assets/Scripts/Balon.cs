using UnityEngine;

public class Balon : MonoBehaviour {
    // Start is called before the first frame update
    public float m_MaxLifeTime = 4f;


    public bool push(float x, float z)
    {

        Vector3 vec = new Vector3(x, 0, z);
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, vec, out hit, 1))
        {
           
            
            return true;


        }
        else
        {
            Destroy(gameObject);
            Debug.Log("holi");
            return false;
        }


    }


    private void Start()
    {
        // If it isn't destroyed by then, destroy the shell after it's lifetime.
        Destroy(gameObject, m_MaxLifeTime);
    }

    // Update is called once per frame
    void Update() {
       
    }
   

}
