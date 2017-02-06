using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour {

    public Renderer textureRenderer;

    public void DrawTexture(Texture2D texture)
    {
        //Using sharedMaterial instead of material allows us to view this within game editor
        textureRenderer.sharedMaterial.mainTexture = texture;

        //Scale plane to fit noisemap size
        textureRenderer.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }
	
}
