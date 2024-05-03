using UnityEngine;

public class LayerChanger : MonoBehaviour
{
    [Header("Header")]

    [Tooltip("Select the vision and inverse layer")]
    public string[] layerNames;

    private int currentLayerIndex = 0; // Index to track layer

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("ChangeLayer", 0f, 5f); //call chanmge layer every x seconds
    }

    private void ChangeLayer()
    {
        if (layerNames.Length == 0)
        {
            Debug.Log("No layer names specified!");
            return;
        }

        string nextLayerName = layerNames[currentLayerIndex];

        int layer = LayerMask.NameToLayer(nextLayerName);
        if (layer == -1)
        {
            Debug.Log("Layer '" +  nextLayerName + " ' does not exist.");
            return;
        }

        gameObject.layer = layer; //changes the layer

        // Increment the layer index or reset to 0 if reached the end of the array
        currentLayerIndex = (currentLayerIndex + 1) % layerNames.Length;

    }
}
