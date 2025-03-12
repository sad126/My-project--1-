using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace assigment35
{
    public class TransformModifier : MonoBehaviour
    {
        public TransformModifier SetPosition(Vector3 position)
        {
            transform.position = position;
            return this;
        }
        public TransformModifier SetRotation(Vector3 rotation)
        {
            transform.rotation = Quaternion.Euler(rotation);
            return this;
        }
        public TransformModifier SetScale(Vector3 scale)
        {
            transform.localScale = scale;
            return this;
        }
    }
}