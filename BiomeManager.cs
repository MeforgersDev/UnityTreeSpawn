using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Biome
{
    public string biomeName;
    public Color biomeColor; // Color representing the biome in the terrain map
    public List<GameObject> treePrefabs; // List of tree prefabs for this biome
}

public class BiomeManager : MonoBehaviour
{
    public List<Biome> biomes;
    public Texture2D terrainMap; // Texture map where each color represents a biome

    /// <summary>
    /// Retrieves the biome at a specific world position based on the terrain map.
    /// </summary>
    /// <param name="position">World position to check.</param>
    /// <returns>The corresponding Biome object or null if none found.</returns>
    public Biome GetBiomeAtPosition(Vector3 position)
    {
        // Convert world position to terrain map coordinates
        int x = Mathf.Clamp(Mathf.RoundToInt(position.x), 0, terrainMap.width - 1);
        int y = Mathf.Clamp(Mathf.RoundToInt(position.z), 0, terrainMap.height - 1);

        Color pixelColor = terrainMap.GetPixel(x, y);

        foreach (var biome in biomes)
        {
            if (biome.biomeColor.Equals(pixelColor))
            {
                return biome;
            }
        }

        return null; // No matching biome found
    }
}
