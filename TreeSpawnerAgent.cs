using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class TreeSpawnerAgent : Agent
{
    public TreeManager treeManager;
    public BiomeManager biomeManager;
    public float spawnRange = 50f;

    public override void OnEpisodeBegin()
    {
        // Clear existing trees at the start of each episode
        foreach (var tree in GameObject.FindGameObjectsWithTag("Tree"))
        {
            Destroy(tree);
        }
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Example observations: Agent's position and current biome information
        sensor.AddObservation(transform.position);

        // Additional environmental observations can be added here
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        // Actions received from the ML model determine where to spawn trees
        float x = vectorAction[0] * spawnRange - (spawnRange / 2);
        float z = vectorAction[1] * spawnRange - (spawnRange / 2);
        Vector3 spawnPosition = new Vector3(x, 0, z);

        Biome biome = biomeManager.GetBiomeAtPosition(spawnPosition);
        if (biome != null && biome.treePrefabs.Count > 0)
        {
            GameObject treePrefab = biome.treePrefabs[Random.Range(0, biome.treePrefabs.Count)];
            Instantiate(treePrefab, spawnPosition, Quaternion.identity);
        }

        // Provide a reward for successful tree spawning
        SetReward(1.0f);
        EndEpisode();
    }

    public override float[] Heuristic()
    {
        // Manual control for testing (e.g., using keyboard input)
        return new float[] { Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") };
    }
}
