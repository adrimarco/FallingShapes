using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected   int     m_value;
    [SerializeField]
    protected   float   movementSpeed;
    [SerializeField]
    protected   float   rotationSpeed;

    /* ENCAPSULATION
     * Create get and set for m_value to make it accesible to anyone but 
     * preventing them from setting it to a value <= 0.
     */
    public int Value
    {
        get { return m_value; }
        set { m_value = Math.Max(value, 1); }
    }

    /* ABSTRACTION
     *  - Move() method moves the object with a default direction and speed that do not need to be known.
     *  - Rotate() modify object rotation without worring about its implementation.
     */
    protected virtual void Update()
    {
        Move();
        Rotate();
    }

    public virtual void Pop() {
        GameManager.Instance.IncreaseScore(Value);

        Destroy(gameObject);
    }

    protected void OnMouseDown() {
        Pop();
    }

     /* POLYMORPHISM
     *  Object can be moved passing a direction and a speed as arguments to Move() or use overloaded Move() without parameters,
     *  which calculates a default direction and uses movementSpeed.
     */
    protected void Move(Vector3 direction, float speed) {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    protected void Move() { 
        Move(GetMovementDirection(), movementSpeed);
    }

    protected virtual void Rotate() {
        if (rotationSpeed == 0) return;

        transform.Rotate(Vector3.forward * Mathf.PI * Time.deltaTime);
        Quaternion rot = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.up);

        transform.rotation *= rot;
    }

    protected virtual Vector3 GetMovementDirection() {
        return Vector3.down;
    }
}
