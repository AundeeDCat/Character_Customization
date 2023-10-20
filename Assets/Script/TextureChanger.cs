using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public List<Texture> jacketTextures = new List<Texture>();
    public Material jacketMaterials;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeJacketColor();
    }

    public void ChangeJacketColor()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int currentTextureIndex = jacketTextures.IndexOf(jacketMaterials.mainTexture);
            currentTextureIndex++;

            if(currentTextureIndex >= jacketTextures.Count)
            {
                currentTextureIndex = 0;
            }

            jacketMaterials.mainTexture = jacketTextures[currentTextureIndex];
        }
    }
}
