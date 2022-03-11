using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GroundGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_GROUND = 50f;

    private const int MAX_GROUND = 4;
    [SerializeField] private Transform groundPart;
    [SerializeField] private GameObject player;

    private Vector3 lastGroundPosition;

    private void Awake() {
        lastGroundPosition = groundPart.Find("GroundEndposition").position;
        SpawnGround();
    }

    private void Update() {
        if (Vector3.Distance(player.transform.position, lastGroundPosition) < PLAYER_DISTANCE_SPAWN_GROUND) {
            SpawnGround();
        }
    }

    private void SpawnGround() {
        Transform lastGroundTranform = SpawnGround(lastGroundPosition);
        lastGroundPosition = lastGroundTranform.Find("GroundEndposition").position;
    }

    private Transform SpawnGround(Vector3 spawnPosition) {
        Transform groundTranform = Instantiate(groundPart, spawnPosition, Quaternion.identity);
        return groundTranform;
    }
}
