﻿using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	private AudioSource audioSource;
	public GameObject enemyProjectile;
	public Transform enemyShotSpawn;
	public float enemyFireRate;
	public float enemyDelay;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		InvokeRepeating("Fire", enemyDelay, enemyFireRate);
	}
	
	void Fire() {
		Instantiate(enemyProjectile, enemyShotSpawn.position, enemyShotSpawn.rotation);
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}