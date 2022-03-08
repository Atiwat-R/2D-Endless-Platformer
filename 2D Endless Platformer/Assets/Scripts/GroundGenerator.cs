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

    private List<GameObject> groundList;
    private void Awake() {
        lastGroundPosition = groundPart.Find("GroundEndposition").position;
        groundList = new List<GameObject>();
        SpawnGround();
    }

    private void Update() {
        if (Vector3.Distance(player.transform.position, lastGroundPosition) < PLAYER_DISTANCE_SPAWN_GROUND) {
            SpawnGround();
        }
        if (groundList.Count > MAX_GROUND)
        {
            DestroyGround();
        }
    }

    private void DestroyGround() {
        for (int i = 0; i < 2; i++) {
            GameObject ground = groundList[i];
            groundList.RemoveAt(i);
            Destroy(ground);
        }
    }

    private void SpawnGround() {
        Transform lastGroundTranform = SpawnGround(lastGroundPosition);
        lastGroundPosition = lastGroundTranform.Find("GroundEndposition").position;
    }

    private Transform SpawnGround(Vector3 spawnPosition) {
        Transform groundTranform = Instantiate(groundPart, spawnPosition, Quaternion.identity);
        groundList.Add(groundTranform.gameObject);
        return groundTranform;
    }
}
