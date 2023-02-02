using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCamera : MonoBehaviour
{
    // Approximate time for the camera to refocus
    [SerializeField]
    private float mDampTime = 0.2f;
    // Space between the top/bottom most target and the screen edge.
    [SerializeField]
    private float mScreenEdgeBuffer = 4f;
    // The smallest orthographic size the camera can be.
    [SerializeField]
    private float mMinSize = 6.5f;
    PlayerManager playerManager;

    private Camera mCamera;
    // Reference speed for the smooth damping of the orthographic size.
    [SerializeField]
    private float mZoomSpeed;
    // Reference velocity for the smooth damping of the position.
    [SerializeField]
    private Vector3 mMoveVelocity;
    // The position the camera is moving towards.
    [SerializeField]
    private Vector3 mDesiredPosition;

    private Vector3 targetLocalPos;
    private void Awake()
    {
        playerManager = FindObjectOfType<PlayerManager>();
        mCamera = GetComponent<Camera>();
    }


    private void FixedUpdate()
    {

        Move();
        Zoom();
    }


    private void Move()
    {
        // Find the average position of the targets.
        FindAveragePosition();

        // Smoothly transition to that position.
        transform.position = Vector3.SmoothDamp(transform.position, mDesiredPosition, ref mMoveVelocity, mDampTime);
    }


    private void FindAveragePosition()
    {
        Vector3 averagePos = new Vector3();
        int numTargets = 0;

        // Go through all the targets and add their positions together.
        for (int i = 0; i < playerManager.mPlayersList.Count; i++)
        {
            // If the target isn't active, go on to the next one.
            if (playerManager.mPlayersList[i] != null)
            {
                if (!playerManager.mPlayersList[i].gameObject.activeSelf)
                    continue;
            }

            // Add to the average and increment the number of targets in the average.
            if (playerManager.mPlayersList[i] != null)
            {
                averagePos += playerManager.mPlayersList[i].transform.position;
                numTargets++;
            }
        }

        // If there are targets divide the sum of the positions by the number of them to find the average.
        if (numTargets > 0)
            averagePos /= numTargets;

        // Keep the same y value.
        averagePos.y = transform.position.y;

        averagePos.z = -10;
        // The desired position is the average position;
        mDesiredPosition = averagePos;
    }


    private void Zoom()
    {
        // Find the required size based on the desired position and smoothly transition to that size.
        float requiredSize = FindRequiredSize();
        mCamera.orthographicSize = Mathf.SmoothDamp(mCamera.orthographicSize, requiredSize, ref mZoomSpeed, mDampTime);
    }


    private float FindRequiredSize()
    {
        // Find the position the camera rig is moving towards in its local space.
        Vector3 desiredLocalPos = transform.InverseTransformPoint(mDesiredPosition);

        // Start the camera's size calculation at zero.
        float size = 0f;

        for (int i = 0; i < playerManager.mPlayersList.Count; i++)
        {

            if (playerManager.mPlayersList[i] != null)
            {
                if (!playerManager.mPlayersList[i].gameObject.activeSelf)
                    continue;
            }

            // find the position of the target in the camera's local space.
            if (playerManager.mPlayersList[i] != null)
            {
                targetLocalPos = transform.InverseTransformPoint(playerManager.mPlayersList[i].transform.position);
            }

            // Find the position of the target from the desired position of the camera's local space.
            Vector3 desiredPosToTarget = targetLocalPos - desiredLocalPos;

            // Choose the largest out of the current size and the distance of the player 'up' or 'down' from the camera.
            size = Mathf.Max(size, Mathf.Abs(desiredPosToTarget.y));

            // Choose the largest out of the current size and the calculated size based on the player being to the left or right of the camera.
            size = Mathf.Max(size, Mathf.Abs(desiredPosToTarget.x) / mCamera.aspect);
        }

        // Add the edge buffer to the size.
        size += mScreenEdgeBuffer;

        // Make sure the camera's size isn't below the minimum.
        size = Mathf.Max(size, mMinSize);

        return size;
    }


    public void SetStartPositionAndSize()
    {
        // Find the desired position.
        FindAveragePosition();

        // Set the camera's position to the desired position without damping.
        transform.position = mDesiredPosition;

        // Find and set the required size of the camera.
        mCamera.orthographicSize = FindRequiredSize();
    }
}
