# Elasticity-Simulation
[WIP] A simulation that showcases the properties of elasticity at varying levels based on user input in the Unity game engine

## Goals
The main goal of this simulation is to provide a user-friendly medium in which to demonstrate the effects of varying amounts of elasticity in an object. The user will be able to select a specific ball based on a mouse input, from there the user can modify an elasticity float value on a slider component to their desired level. The user will also be able to select and move the selected ball with their mouse, allowing them to move it in whichever way they please.

## Implementation
The effect of elasticity will be achieved through the use of an `Elasticity` class, which holds the properties to be used in the physics calculations. The class will hold the standard functions of `SetElasticValue(float value)` and `GetElasticValue()`, in addition to a `ApplyElasticity(Ball ball)`, which takes an instance of the `Ball` class as an argument, allowing specific ball objects to have certain levels of elasticity.

For the physics effects of gravity, air resistance, and inertia, the Unity scripting API class of `Rigidbody` will be used. The `PhysicsManager` class will inherit the `Rigidbody` class, as well as having an instance of the `Elasticity` class, in order to implement the elasticity float value into calculations for the movement of the ball.

## Updates
[Updates will be posted here] 
