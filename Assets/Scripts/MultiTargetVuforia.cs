using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetsForia : MonoBehaviour
{
    [SerializeField] private GameObject startModel;
    private int modelCount;
    private int indexCurrentModel;

    // Start is called before the first frame update
    void Start()
    {
        modelCount = transform.childCount;
        indexCurrentModel = startModel.transform.GetSiblingIndex();
    }

    public void ChangeModel(int index)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);

        int newIndex = indexCurrentModel + index;

        if (newIndex < 0)
        {
            newIndex = modelCount - 1;
        }
        else if (newIndex > modelCount - 1)
        {
            newIndex = 0;
        }

        GameObject newModel = transform.GetChild(newIndex).gameObject;
        newModel.SetActive(true);

        indexCurrentModel = newModel.transform.GetSiblingIndex();
    }
}
