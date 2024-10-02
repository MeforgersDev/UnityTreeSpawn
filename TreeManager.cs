using UnityEngine;

public class TreeManager : MonoBehaviour
{
    public BiomeManager biomeManager;
    public float spawnRange = 50f;
    public float treeDensity = 5f; // Distance between trees

    /// <summary>
    /// Spawns trees across the terrain based on biome information.
    /// </summary>
    public void SpawnTrees()
    {
        for (float x = -spawnRange; x < spawnRange; x += treeDensity)
        {
            for (float z = -spawnRange; z < spawnRange; z += treeDensity)
            {
                Vector3 position = new Vector3(x, 0, z);
                Biome biome = biomeManager.GetBiomeAtPosition(position);
                if (biome != null && biome.treePrefabs.Count > 0)
                {
                    GameObject treePrefab = biome.treePrefabs[Random.Range(0, biome.treePrefabs.Count)];
                    Instantiate(treePrefab, position, Quaternion.identity);
                }
            }
        }
    }
}
