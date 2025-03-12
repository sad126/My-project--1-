using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Vector3 = UnityEngine.Vector3;
namespace assigment35
{
    public class ChainabbleMethods : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            TransformModifier modifier = gameObject.AddComponent<TransformModifier>();
            modifier.SetPosition(new Vector3(2, 3, 0))
            .SetRotation(new Vector3(0, 45, 0))
            .SetScale(new Vector3(1.5f, 1.5f, 1.5f));
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    
}