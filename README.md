# RubiksCube
> Rubik's Cube editor and solver made in Unity and written in C#.

Initially created to assist my Rubik's Cube robot solver. The Unity game engine seemed like a perfect way to easily implement a nice 3D environment for the user to populate colors on a cube. Additionally, it allowed a simple way to implement C# scripts on game objects.

## Images
![alt text](https://github.com/KacperBazan/RubiksCube/blob/main/Custom%20Rubiks%20Cube%20Editor/Assets/Images/s1.PNG)
![alt text](https://github.com/KacperBazan/RubiksCube/blob/main/Custom%20Rubiks%20Cube%20Editor/Assets/Images/s3.PNG)

## Credits
- **[Morwen Thistlethwaite](https://en.wikipedia.org/wiki/Morwen_Thistlethwaite)** - Knot theorist who devised algorithm that splits up the cube into subgroups.

- **[Herbert Kociemba](http://kociemba.org/)** - German cuber who improved [Thistlethwaite's algorithm](https://www.speedsolving.com/wiki/index.php/Thistlethwaite%27s_algorithm) for near-optimal solves.

- **[Matt Colbourne](https://github.com/Megalomatt)** (*[Megalomobile](https://www.megalomobile.com/lets-make-and-solve-a-rubiks-cube-in-unity/)*) - Created YouTube series that assisted in designing the cube in Unity, 		 and ported Kociemba's Java code into C# for easy implementation into Unity projects.

The algorithm that solves the Rubik's Cube is based around *Kociemba's Algortith*, which can be read about [here](https://en.wikipedia.org/wiki/Optimal_solutions_for_Rubik%27s_Cube) and [here](https://www.speedsolving.com/wiki/index.php/Kociemba's_Algorithm). Massive thanks to Matt Colbourne for his [YouTube series](https://www.youtube.com/watch?list=PLuq_iMEtykn-ZOJyx2cY_k9WkixAhv11n&v=JN9vx0veZ-c&feature=emb_title) on creating a Rubik's cube project in Unity. Although my project deviates in the way you could input colors onto a Rubik's cube, he's the one that presented a super clear tutorial on building a functioning Rubik's cube. Many of the ideas for my own project were inspired from his code and tutorials, and without his refactoring of Kociemba's code, this wouldn't be possible.

## Controls and Buttons

| Input  | Function |
| ------------- | ------------- |
| Right Click (*Drag*)  | Pan Cube Around Primary and Secondary Axis  |
| Mouse Wheel (*Up/Down*) | Pan Cube Around Tertiary Axis   |
| Left Click (*On Button*) | Change Color of Cursor   |
| Left Click (*On Cube*)  | Sets Color of Cube to Color of Cursor  |
| Middle Mouse Click  | Reset Cube Orientation |
| R  | Reset Cube Orientation |
>


| Button  | Function |
| ------------- | ------------- |
| Any Color  | Sets Cursor to Button Color  |
| Solve<sup>1</sup>  | Displays Moves to Solve Cube  |
| Reset | Resets Cube Colors to Default (*Solved*)   |

<sup>1</sup> The correct orientation of the cube will always be Red as the Front (*F*) face and White as the Up (*U*) face.

## Installation

>**Note:** Currently my packages aren't exporting correctly. It would be better if you just downloaded the files in the folder and drag them into your project.

1. Download the Unity Package from the **Releases**.
2. Open a new or existing unity project.
3. Click on **Assets** > **Import Package** > **Custom Package**.
4. Select the downloaded Unity Package from Releases.
5. Select **All**
6. Select **Import**

## Licensing
*Copyright © 2020 Kacper Bazan* - Email: **bazankacper25@gmail.com**

*Distributed under the [GPLv3](https://github.com/KacperBazan/RubiksCube/blob/main/LICENSE) license*
