# RubiksCube
> Rubik's Cube editor and solver made in Unity and written in C#.

Initially created to assist my Rubik's Cube robot solver. The Unity game engine seemed like a perfect way to easily implement a nice 3D environment for the user to populate colors on a cube. Additionally, it allowed a simple way to implement C# scripts on game objects.

## Credits
- **[Morwen Thistlethwaite](https://en.wikipedia.org/wiki/Morwen_Thistlethwaite)** - Knot theorist who devised algorithm that splits up the cube into subgroups.

- **[Herbert Kociemba](http://kociemba.org/)** - German cuber who improved [Thistlethwaite's algorithm](https://www.speedsolving.com/wiki/index.php/Thistlethwaite%27s_algorithm) for near-optimal solves.

- **[Matt Colbourne](https://github.com/Megalomatt)** (*[Megalomobile](https://www.megalomobile.com/lets-make-and-solve-a-rubiks-cube-in-unity/)*) - Created YouTube series that assisted in designing the cube in Unity, 		 and ported Kociemba's Java code into C# for easy implementation into Unity projects.

The algorithm that solves the Rubik's Cube is based around *Kociemba's Algortith*, which can be read about [here](https://en.wikipedia.org/wiki/Optimal_solutions_for_Rubik%27s_Cube) and [here](https://www.speedsolving.com/wiki/index.php/Kociemba's_Algorithm). Massive thanks to Matt Colbourne for his [YouTube series](https://www.youtube.com/watch?list=PLuq_iMEtykn-ZOJyx2cY_k9WkixAhv11n&v=JN9vx0veZ-c&feature=emb_title) on creating a Rubik's cube project in Unity. Although my project deviates in the way you could input colors onto a Rubik's cube, he's the one that presented a super clear tutorial on building a functioning Rubik's cube. Many of the ideas for my own project were inspired from his code and tutorials, and without his refactoring of Kociemba's code, this wouldn't be possible.
