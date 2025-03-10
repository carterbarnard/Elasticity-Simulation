# Elasticity-Simulation
[WIP] A simulation that showcases the properties of elasticity at varying levels based on user input in the Unity game engine

## Goals
The main goal of this simulation is to provide a user-friendly medium in which to demonstrate the effects of varying amounts of elasticity in an object. The user will be able to select a specific ball based on a mouse input, from there the user can modify an elasticity float value on a slider component to their desired level. The user will also be able to select and move the selected ball with their mouse, allowing them to move it in whichever way they please.

## Implementation
The implementation of elasticity in the model is done through the use of the following classes:

### Elasticity
The effect of elasticity will be achieved through the use of an `Elasticity` class, which holds the properties to be used in the physics calculations. The class will hold the standard functions of:

  - `SetElasticValue(float value)`: assigns a float value to the `elasticValue` attribute
  
  - `GetElasticValue()`: returns the `elasticValue` attribute
  
  - `ApplyElasticity(Ball ball)`: takes an instance of the `Ball` class as an argument, allowing specific ball objects to have certain levels of elasticity.

### PhysicsManager
For the physics effects of gravity, air resistance, and inertia, the Unity scripting API class of `Rigidbody` will be used. The `PhysicsManager` class will inherit the `Rigidbody` class, as well as having an instance of the `Elasticity` class, in order to implement the elasticity float value into calculations for the movement of the ball. The functions present in this class are:

  - `AddForce(Vector3 force, ForceMode force, float elasticValue)`: uses the the arguments of a `Vector3`, `ForceMode`, and elasticity value in the form of a float value to determine the path of the ball
    
  - `ApplyElasticity(Ball ball)`: uses the `ApplyElasticity(Ball ball)` function from the `Elasticity` class to allow certain balls to have different levels of elasticity

### Ball
The `Ball` class represents the state of each ball object in the simulation. The attributes of this class include an instance of the `PhysicsManager` class, in addition to the functions below

  - `IfCollision()`: calls for the opposite force to be applied, along with the new trajectory on collision with another object
    
  - `UpdatePosition(Vector3 vec3)`: updates position of the ball object using `Vector3` object using `ApplyForce(Vector3 force)` function
    
  - `ApplyForce(Vector3 force)`: used as a helper function in the `UpdatePosition(Vector3 vec3)` function

## Updates
[Updates will be posted here] 
