using UnityEngine;

public class AdamMovement : MonoBehaviour
{
    public int Speed = 10;
    public GameObject Camera;
    private CharacterController _animator;


    // Use this for initialization
	void Start ()
	{
	    var y = Terrain.activeTerrain.SampleHeight(this.transform.position);
	    this.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	    _animator = GetComponent<CharacterController>();        
	}
	
	// Update is called once per frame
	void Update () {
        Move(
            Input.GetKeyDown("w"),
            Input.GetKeyDown("s"),
            Input.GetKeyDown("a"),
            Input.GetKeyDown("d")
            );
    }

    private void Move(bool forward, bool back, bool left, bool right)
    {
        var position = transform.position;
        if (left != right)
        {
            position.x += (left ? -1 : 1) * Speed;
        }
        if (forward != back)
        {
            position.z += (left ? -1 : 1) * Speed;
        }
        position.y = Terrain.activeTerrain.SampleHeight(position);
        transform.position = position;
    }
}
