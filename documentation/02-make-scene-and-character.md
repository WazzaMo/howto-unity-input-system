# Make a Fresh Scene and Character

You need a scene and character so you can see input making
something move. You have many options but this page
provides instructions for creating your own scene and character,
which can be a good exercise if you're newer to Unity.

We will create a simple character in a blank scene

## 1-0 Create a simple scene

The scene and character just needs to be enough to see movement
working.

### 1-1: Create new scene

Go to menu Assets | Create | Scene.
![Assets menu - Create Scene](./images/1-1--CreateScene.jpg "Unity menu")

### 1-2: Rename new scene file

Then give your new scene file a name in the Project panel.
The file will appear in the current folder in the `Project` panel.
It's a good idea to have a folder called `Scenes` and put your
scenes there.

![Rename `New Scene`](./images/1-2--Name-Scene-File.jpg)

Rename "New Scene" to better indicate what your scene is about.
For this one it could be "Simple Input."

## 1-2 Create ground and character

Add a plane as a very simple ground. We won't worry about applying
materials, so this will be a very nice and boring white.

### 1-2-1 Create 3D Object | Plane

Use the `GameObject` menu to create a plane.
Click: GameObject | 3D Object | Plane

![GameObject menu image](./images/1-2-1--Create-3D-Plane.jpg)

### 1-2-2 Set position to 0, 0, 0

Use the Inspector panel to see the properties of the plane.
If you cannot vind the Inspector, then use the Window menu
to open it.

Edit position to be 0, 0, 0.

![Edit position in Inspector](./images/1-2-2--Set-Position-to-0-0-0.jpg)

### 2-0 Create simple character objects

Our character will have a Sphere body and a capsule for a nose.
The sphere will be the root game object and the capsule will be a child of the sphere.

#### 2-1 Use menu: GameObject | 3D Object | Sphere

![Add sphere](./images/2-1--add-sphere.jpg)

#### 2-2 Use menu: GameObject | 3D Object | Capsule

![Add capsule](./images/2-2--add-capsule.jpg)

### 2-3 Make capsule into a nose.

#### 2-3-1 Make Capsule child of Sphere

In the `Hierarchy` panel, drag the *Capsule* object into the
*Sphere* object so it becomes a child.

![Make capsule child of sphere](./images/2-3-1--make-capsule-child-of-sphere.jpg)

#### 2-3-2 Scale down the Capsule

With the *Capsule* still selected in the Hierarchy,
go to the inspector and change the scale to 0.2, 0.2, 0.2
so that the capsule is one-fifth the size of the sphere.

![Use inspector to shrink capsule](./images/2-3-2--shrink-capsule-to-one-fifth.jpg)

Because the capsule is a child of the sphere, any position
entered in the Inspector will move the capsule RELATIVE to the 
sphere.

#### 2-3-3 Make Capsule poke out of Sphere

Make the capsule poke out of the sphere, that has radius 1,
in the positive Z direction, so it becomes a nose.

In the inspector, set the position to: 0, 0, 0.45

![Make capsule poke out in Z](./images/2-3-3--set-capsule-to-poke-out-in-Z.jpg)

#### 2-3-4 Rotate Capsule 90 Degrees

We need to rotate the capsule so it looks like a nose.
In the inspector, change the rotation to: 90, 0, 0
This rotates the capsule 90 degrees in the X axis.

![Rotate capsule 90 degrees](./images/2-3-4--rotate-capsule.jpg)

Almost done, now...

### 2-4 Make Sphere the Character

#### 2-4-1 Correct Sphere Position

At this point, the sphere will have a random position and may
be part submerged in the plane, like this...

![Sphere position is random](./images/2-4-1--sphere-with-nose-is-half-submerged.jpg)

We should see the capsule
poking out in the positive direction of the Z axis, indicated
by the blue arrow in the Scene View.

1. Select the Sphere in the Hierarchy panel.
2. Edit `position` in the Inspector to be: 0, 1, 0

![Correct sphere position](./images/2-4-1--Correct-sphere-position.jpg)

And now the sphere is ready to be a character and the nose shows the direction where it will go.

![Sphere is ready](./images/2-4-1--Sphere-ready-as-character.jpg)

#### 2-4-2 Rename Sphere to Character

Using the `Hierachy` panel, with the Sphere selected (should already be), right-click and choose **Rename**

![right click and choose rename](./images/2-4-2--Right-click-and-choose-rename.jpg)

Type `Character` and press ENTER.

![Type Character](./images/2-4-2--Type-Character-and-press-enter.jpg)

# Congrats! Your Character is Done

Your scene and character are ready.

----------------------------------------------------------------------

**NEXT**: [Get Action events in C# code and debug it](./03-create-a-character-motioninput-component.md)
