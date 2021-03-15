using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantor : MonoBehaviour
{
    public int _depth;
    public float _width;
    public GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
        CantorSet(_depth, 0, _width);
    }

    void CantorSet(int levels, float left, float right)
    {
        if (levels >= 0) 
        {
            float xPos = (right + left) / 2;
            float size = right - left;

            GameObject cube = Instantiate(_cube);
            cube.transform.position = new Vector3(xPos, levels*10, 200);
            cube.transform.localScale += new Vector3(size-1, 10, 200);

            float leftA = left + size * 0;
            float rightA = left + size * 1/3;
            float leftB = left + size*2/3;
            float rightB = left + size;

            CantorSet(levels - 1, leftA, rightA);
            CantorSet(levels - 1, leftB, rightB);

        }
    }
}
