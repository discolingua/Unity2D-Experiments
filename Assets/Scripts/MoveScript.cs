﻿using UnityEngine;


/// <summary>
///   Player controller and behavior
/// </summary>

public class MoveScript : MonoBehaviour {

    // 1 - Designer variables

    /// <summary>
    ///   Object speed
    /// </summary>

    public Vector2 speed = new Vector2(10,10);

    /// <summary>
    ///   Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
	

	void Update () {
        // 2 - Movement
        movement = new Vector2(
                               speed.x * direction.x,
                               speed.y * direction.y);
	}

    void FixedUpdate() {
        // 5 - Move the game object
        rigidbody2D.velocity = movement;
    }
}
