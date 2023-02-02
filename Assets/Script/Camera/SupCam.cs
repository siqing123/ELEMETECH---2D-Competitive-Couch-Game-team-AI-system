using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupCam : MonoBehaviour
{
    public FocusLevel FocusLevel;
    private PlayerManager playerManager;

    [SerializeField]
    private float DepthUpdateSpeed = 5f;
    [SerializeField]
    private float AngleUpdateSpeed = 7f;
    [SerializeField]
    private float positionUpdateSpeed = 5f;

    [SerializeField]
    private float DepthMax = -10f;
    [SerializeField]
    private float DepthMin = -22f;

    [SerializeField]
    private float AngleMax = 11f;
    [SerializeField]
    private float AngleMin = 3f;

    [SerializeField]
    private float CameraEulerX;
    [SerializeField]
    private Vector3 CameraPosition;

    private void Awake()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    void Start()
    {
        playerManager.mPlayersList.Add(FocusLevel.gameObject);
        
    }
   
    private void LateUpdate()
    {
        CalculateCameraLocations();
        MoveCamera();
    }

    private void MoveCamera()
    {
        Vector3 position = gameObject.transform.position;
        if (position != CameraPosition)
        {
            Vector3 targetPosition = Vector3.zero;
            targetPosition.x = Mathf.MoveTowards(position.x, CameraPosition.x, positionUpdateSpeed * Time.deltaTime);
            targetPosition.y = Mathf.MoveTowards(position.y, CameraPosition.y, positionUpdateSpeed * Time.deltaTime);
            targetPosition.z = Mathf.MoveTowards(position.z, CameraPosition.z, DepthUpdateSpeed * Time.deltaTime);
            gameObject.transform.position = targetPosition;
        }

        Vector3 localEulerAngles = gameObject.transform.localEulerAngles;
        if (localEulerAngles.x != CameraEulerX)
        {
            Vector3 targetEulerAngles = new Vector3(CameraEulerX, localEulerAngles.y, localEulerAngles.z);
            gameObject.transform.localEulerAngles = Vector3.MoveTowards(localEulerAngles, targetEulerAngles, AngleUpdateSpeed * Time.deltaTime); ;
        }
    }

    private void CalculateCameraLocations()
    {
        Vector3 averageCenter = Vector3.zero;
        Vector3 totalPositions = Vector3.zero;
        Bounds playerBounds = new Bounds();

        for (int i = 0; i < playerManager.mPlayersList.Count; i++)
        {
            Vector3 playerPosition = playerManager.mPlayersList[i].transform.position;

            if(FocusLevel.FocusBounds.Contains(playerPosition))
            {
                float playerX = Mathf.Clamp(playerPosition.x, FocusLevel.FocusBounds.min.x, FocusLevel.FocusBounds.max.x);
                float playerY = Mathf.Clamp(playerPosition.y, FocusLevel.FocusBounds.min.y, FocusLevel.FocusBounds.max.y);
                float playerZ = Mathf.Clamp(playerPosition.z, FocusLevel.FocusBounds.min.z, FocusLevel.FocusBounds.max.z);
                playerPosition = new Vector3(playerX, playerY, playerZ);
            }

            totalPositions += playerPosition;
            playerBounds.Encapsulate(playerPosition);
        }

        averageCenter = (totalPositions / playerManager.mPlayersList.Count);

        float extents = (playerBounds.extents.x + playerBounds.extents.y);
        float lerpPercent = Mathf.InverseLerp(0, (FocusLevel.HalfXBounds + FocusLevel.HalfYBounds) / 2, extents);

        float depth = Mathf.Lerp(DepthMax, DepthMin, lerpPercent);
        float angle = Mathf.Lerp(AngleMax, AngleMin, lerpPercent);

        CameraEulerX = angle;
        CameraPosition = new Vector3(averageCenter.x, averageCenter.y, depth);
    }
}
