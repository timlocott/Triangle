# Triangle

Triangle is small project that gives details side lengths and angles for triangles.

## Usage

To use this program simply enter 3 side lengths for the desired triangle that you would like to make. 

<img width="971" alt="SideLengths" src="https://github.com/timlocott/Triangle/assets/61839402/a51c8d54-eea3-45ab-99f2-99888e59cba8">

## Important Files

The MainPage.xaml.cs file acts as the model for the project.

The MainPage.xaml file acts as the view for the project.

The Triangle.cs class allows the creation of "triangle" objects which have properties for each side length and angle. Private methods are also included which classify the triangle and calculate the triangle's vertices coordinates.

## Behavior

If sides entered create a valid triangle, a message will appear saying so and also classifying the triangle based on side lengths and angle sizes.

<img width="971" alt="SuccessMessage" src="https://github.com/timlocott/Triangle/assets/61839402/c756e570-47ff-4d06-b1b3-1d31bbee446d">

If sides entered do not create a valid triangle, a toast (short-duration message) will appear saying so.

<img width="971" alt="NotValid" src="https://github.com/timlocott/Triangle/assets/61839402/6afa6c18-a115-4561-a8ec-1824a11fe8b1">

If sides entered are not positive or a number, a toast (short-duration message) will appear saying so.

<img width="971" alt="NotPositive" src="https://github.com/timlocott/Triangle/assets/61839402/528cba01-f38f-405f-a05d-479a253e305d">

If the side length is not a number the text in the entry field will turn red, and green if it is a number.

<img width="971" alt="ValidInput" src="https://github.com/timlocott/Triangle/assets/61839402/387923c6-fa5a-4dcc-83ea-c5ef440cc210">

A tooltip will appear if a user hovers their mouse over the green question mark icon.

<img width="971" alt="Tooltip" src="https://github.com/timlocott/Triangle/assets/61839402/76594531-5eba-499c-b5dc-d2e5ae076832">

## Project Status

The main functionality of the project has been implemented and has been tested. A drawing feature would be nice to have in the future and has been partially implemented.

## TODO

Implement a drawing feature for the triangle created from the entered side lengths. Coordinates calculations for the vertices of the triangles have already been implemented.

## Author(s)

Tim Cottrell









