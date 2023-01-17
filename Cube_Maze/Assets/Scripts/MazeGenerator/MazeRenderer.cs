using UnityEngine;
using System;

public class MazeRenderer : MonoBehaviour
{
    //стороны лабиринта-куба
    public enum SideType
    {
        Up,
        Left,
        Right,
        Down,
        Front,
        Back
    }

    [SerializeField]
    private SideType _sideType;

    //размеры лабиринта
    private int width = 8;
    private int height = 8;
    private float size = 1f;

    [SerializeField]
    private Transform wallPrefab = null;

    void Start()
    {
        var maze = MazeGenerator.Generate(width, height);
        Draw(maze);
    }

    private void Draw(WallState[,] maze)
    {

        for (int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                var cell = maze[i, j];
                var position = new Vector3(-width / 2 + i, 0, -height / 2 + j);

                if (cell.HasFlag(WallState.UP))
                {
                    var topWall = Instantiate(wallPrefab, transform) as Transform;
                    topWall.position = position + new Vector3(0, 0, size / 2);
                    topWall.localScale = new Vector3(size, topWall.localScale.y, topWall.localScale.z);
                }

                if (cell.HasFlag(WallState.LEFT))
                {
                    var leftWall = Instantiate(wallPrefab, transform) as Transform;
                    leftWall.position = position + new Vector3(-size / 2, 0, 0);
                    leftWall.localScale = new Vector3(size, leftWall.localScale.y, leftWall.localScale.z);
                    leftWall.eulerAngles = new Vector3(0, 90, 0);
                }

                if (i == width - 1)
                {
                    if (cell.HasFlag(WallState.RIGHT))
                    {
                        var rightWall = Instantiate(wallPrefab, transform) as Transform;
                        rightWall.position = position + new Vector3(+size / 2, 0, 0);
                        rightWall.localScale = new Vector3(size, rightWall.localScale.y, rightWall.localScale.z);
                        rightWall.eulerAngles = new Vector3(0, 90, 0);
                    }
                }

                if (j == 0)
                {
                    if (cell.HasFlag(WallState.DOWN))
                    {
                        var bottomWall = Instantiate(wallPrefab, transform) as Transform;
                        bottomWall.position = position + new Vector3(0, 0, -size / 2);
                        bottomWall.localScale = new Vector3(size, bottomWall.localScale.y, bottomWall.localScale.z);
                    }
                }
            }

        }
        switch(_sideType)
        {
            case SideType.Down:
                transform.position += new Vector3(0.5f, - height/2, -0.5f);
                transform.Rotate(180, 0, 0);
                break;
            case SideType.Up:
                transform.position += new Vector3(0.5f, + height/2, +0.5f);
                break;
            case SideType.Right:
                transform.position += new Vector3(width/2, 0.5f, -0.5f);
                transform.Rotate(0, 180, 90);
                break;
            case SideType.Left:
                transform.position += new Vector3(-width / 2, 0.5f, 0.5f);
                transform.Rotate(0, 0, 90);
                break;
            case SideType.Front:
                transform.position += new Vector3(0.5f, -0.5f, width/2);
                transform.Rotate(90, 0, 0);
                break;
            case SideType.Back:
                transform.position += new Vector3(-0.5f, -0.5f, -width / 2);
                transform.Rotate(90, 180, 0);
                break;
        }
        
    }
}