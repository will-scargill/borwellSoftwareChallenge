# Borwell Software Challenge

https://borwell.com/career/

A program to calculate floor area, room volume, and required wall area coverage of paint for a room given its dimensions.

## Build Instructions

#### Requirements

[Visual Studio](https://visualstudio.microsoft.com/downloads/)

[7zip (or other archive software)](https://www.7-zip.org/download.html)

#### How to build

1. Download borwellSoftwareChallenge.zip

2. Extract files to suitable location using 7zip (or other archive software)

3. Open `borSoftwareChallenge.sln` in Visual Studio

4. Click `Publish borSoftwareChallenge` in the `Build` menu

5. Click `Browse` and select a suitable location

6. Click `Next`

7. Click `Next` 

8. Click `Finish` and wait for Visual Studio to compile the program

9. Open `setup.exe` in your selected directory and install the program

## Usage

![https://imgur.com/a/Aimrnyf](https://i.imgur.com/2H0oIa1.png)

#### Basic Room Dimensions

In the boxes titled `Room Length`, `Room Width`, and `Room Height`, enter the aforementioned information

#### Recesses (Doors and Windows)

In the boxes titled `Recess Name`, `Recess Width`, `Recess Height`, and `Recess Depth`, enter the aforementioned information

If the recess is a door, check the `Is recess a door?` checkbox

Then click `Add Recess`

The recess will be displayed via its name in the listbox. To remove a recess, right click the recess you want to remove and click `Remove`

- If the recess is a door, the floor area of the recess is added to the overall floor area calculated. If not (and thereford treated as a window) the floor area is not added

- For all recesses the sides and upper area is added to the paint coverage area, it is assumed that all windows have a window sill which does not use wall paint

- If a recess has a depth of zero, E.G an internal door rather than a patio door, no additional paint coverage area is calculated

#### Calculating values

Once all desired dimensions have been entered, click the `Calculate` button

The right hand text boxes will then display the calculated information

*Value of paint in litres calculated is based on average coverage of a Dulux emulsion paint where 32m² coverage requires 2.5 litres*

#### Calculating values for non-quadrilateral room (E.G. L-Shaped room)

##### Example

![https://imgur.com/a/rBtcNtw](https://i.imgur.com/swWgmzD.png)

Take the room displayed above. To calculate all required values, you must calculate `Main Room` and `Alcove` seperately and then sum the values

1. Enter dimensions of `Main Room`

2. Add `Alcove` entrance (A to B) as a door recess with a depth of 0 and height of `Main Room` (Displayed below)

![https://imgur.com/a/QiVnuvU](https://i.imgur.com/KG7J2Ce.png)

3. Record values given

4. Enter dimensions of `Alcove`

5. Add `Alcove` entrance (A to B) as a door recess with a depth of 0 and height of `Main Room` (Displayed below)

![https://imgur.com/a/krhAFCt](https://i.imgur.com/F8kPab0.png)

6. Add values given to previously recorded values




