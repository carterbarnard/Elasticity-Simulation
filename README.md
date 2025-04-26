# Elasticity-Simulation
A simulation that showcases the properties of elasticity at varying levels based on user input in the Unity game engine

## Goals
The main goal of this simulation is to provide a user-friendly medium in which to demonstrate the effects of varying amounts of elasticity in an object. The user will be able to select varying levels of elasticity based on slider input, in addition to manipulating the position of the ball in order to observe the behavior when colliding with angled surfaces using slider inputs.

## Implementation
The simulation makes use of Unity's `Rigidbody` component in order to handle the physics of the subject, as well as `PhysicsMaterial` component in order to simulate the elasticity of an object. The user interacts with the simulation through the use of sliders and buttons on screen, with a "Reset" button resetting the ball's position and velocity, and a "Start" button beginning the simulation in order to test the effects of the elastic value when interacting with varying positions and angles in the simulation area. The user can manipulate the elastcity value via a slider located in the bottom right of the screen with a value of 0-100 representing the percentage of elasticity on the object (o means it conserves 0% of the energy on impact, 100% means it conserves all the energy upon impact, bouncing it to the same postion in which is dropped). The user can also manipulate the ball's position in the x-axis using the slider located at the bottom-middle of the screen, as well as the ball's y-axis with the slider located on the right side of the screen. The implementation of elasticity in the model is done through the use of the following classes:

### `BallInfo`
The class, `BallInfo` holds information regarding the ball's position, elasticity level, and collision is held here, for purposes of data display and statisitic calculations. The class will override some of the standard fucntions of Unity's `MonoBehavior` class, which include:

  - `Start()`: Assigns a value of `false` to the `hasBounced` boolean variable, for calculating the max height of the ball. Also sets the display text for information on the ball's position and elasticity percentage.
  
  - `Update()`: If `hasBounced` is true, then the max height is calculated, displaying the height the ball reached after the initial bounce. Also updates the displayed position of the ball every frame.
  
  - `OnColisionEnter(Collision col)`: Assigns `true` to `hasBounced` variable if the ball has collided with a surface in the simulation.

### `ElasticitySlider`
The `ElasticitySlider` class inherits the methods of the `MonoBehavior` class, overiding its `Start()` function. Handles the behavior of the slider the user interacts with to manipulate the value of elasticity on the ball in the simulation

  - `Start()`: Declares an instance of a material from the GameObject's (ball's) collider component, for the purpose of editing the bounciness attribute of the ball. Additionally sets the min/max value of the slider from 0-100 in the user interface, as well as implementing an event listener for the `OnSliderChange()` function.
    
  - `OnSliderChange(float sliderValue)`: When the slider value is changed in the user interface, sets the material of the ball GameObject's bounciness value to a value equivalent to `sliderValue / 100` (since the `bounciness` variable from the `PhysicsMaterial class is a float value from 0-1).

### `UserInput`
The `UserInput` class represents the state of the simulation. Much like previous classes, this inherits and overrides the `Start()` function from the `MonoBehavior` class

  - `Start()`: Assigns instance of the `BallInfo` component to the ballInfo variable, as well as an instance of the `Rigidbody` component to the ballRB variable. Event listeners are also added to the Start and Reset button from the user interface
    
  - `WhenStartClicked()`: Sets `ballRB.isKinematic = false` so the ball is affected by the physics when the user presses the Start button in the UI. 
    
  - `WhenResetClicked()`: Sets `ballRB.isKinematic = true` so the ball is not affected by the physics when the user presses the Reset button in the UI, allowing them to position the ball and set their desired elasticity value. Also sets the velcoty of the ball to zero and places the ball in a neutral position in the center of the screen. The information display is also reset for new runs of data collection.

### `XPositionSlider`
This class handles the positioning on the x-axis of the ball, allowing the user to manipulate its position based on a slider in the UI. Inherits from `MonoBehavior`

  - `Start()`: Sets min/mmax values of the slider and adds listener for slider change events.
  
  - `OnSliderChange(float sliderValue)`: Moves the ball's x-axis position based on the value for the slider.

### `YPositionSlider`
This class handles the positioning on the y-axis of the ball, allowing the user to manipulate its position based on a slider in the UI. Inherits from `MonoBehavior`

  - `Start()`: Sets min/mmax values of the slider and adds listener for slider change events.
  
  - `OnSliderChange(float sliderValue)`: Moves the ball's y-axis position based on the value for the slider.

## Updates
[Updates will be posted here] 
