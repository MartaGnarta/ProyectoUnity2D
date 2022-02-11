using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Mesh model;

    public Material playerMaterial;
    public Material enemiesMaterial;

    public Transform player;
    public Transform gameCamera;
    public Transform[] enemies;

    public float scale = 0.5f;
    public float dotsScale = 0.2f;

    public Vector3 cameraOffset;

    void Update()
    {
        Vector3 playerW = player.position;
        Vector3 playerC = gameCamera.InverseTransformPoint(playerW);
        //gameCamera.worldToLocalMatrix.MultiplyPoint(playerW);
        //gameCamera.localToWorldMatrix.inverse.MultiplyPoint(playerW);

        Matrix4x4 playerMatrix = gameCamera.localToWorldMatrix * Matrix4x4.Translate(cameraOffset) *
                                 Matrix4x4.Scale(Vector3.one * scale) * Matrix4x4.Translate(playerC)
                                 * Matrix4x4.Scale(Vector3.one * dotsScale);

        Graphics.DrawMesh(model, playerMatrix, playerMaterial, 5);

        for (int i = 0; i < enemies.Length; i++)
        {
            Vector3 enemyW = enemies[i].position;
            Vector3 enemyC = gameCamera.InverseTransformPoint(enemyW);

            Matrix4x4 enemyMatrix = gameCamera.localToWorldMatrix * Matrix4x4.Translate(cameraOffset) *
                                    Matrix4x4.Scale(Vector3.one * scale) * Matrix4x4.Translate(enemyC) 
                                    * Matrix4x4.Scale(Vector3.one * dotsScale);

            Graphics.DrawMesh(model, enemyMatrix, enemiesMaterial, 5);
        }
    }
}
