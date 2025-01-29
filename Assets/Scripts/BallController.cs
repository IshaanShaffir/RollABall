using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] float ballSpeed;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXYZPlane = new(input.x, 0, input.y);
        sphereRigidBody.AddForce(inputXYZPlane * ballSpeed);
    }

    
}
