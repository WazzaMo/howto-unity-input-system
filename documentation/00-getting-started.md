# Getting Started

You might be here because you have a scene and character, and
you want to use the Input System package and find the Unity
documentation unhelpful. I feel your pain - been there.

You might, instead, be newer to Unity and want to try creating
a scene and basic character and try the new Input System.
That's a little different but I have you covered, too.

## Where to Start?

You will need to install the Input System package, if not already done,
have a character to control and then create an Input Action asset
to link input devices (say keyboard) to events and define the type
of control (button, vector2 etc)...

The sections below, numbered 1 and onwards, can be taken
in turn or on their own as best suits your needs.

--------------------------------------------------------

### 1 - Install Input System

First things first, make sure the Input System package is installed
(if not already).

See [01-installation.md](./installation.md) for
an overview and link to Unity's installation guide - that guide is OK.

Then choose one of the two starting points below.

--------------------------------------------------------

### 2 - Making a basic Character

There are assets on the AssetStore for characters you could control.

Let's assume for the moment you want to make something rough and learn a bit
about setting up a scene in the process - that's what this is about.

Follow the instructions in [02-make-scene-and-character.md](./02-make-scene-and-character.md)
for detailed instructions on how to create a basic scene and
character. It's not pretty but it's enough to start with.

--------------------------------------------------------

### 3 - Configuring Input Actions and debugging them

Let's figure out how the Input System Actions turn into events received in C# code.
In this section we write a `MotionInput` controller and set up an Input Actions
asset and debug it. It's a long one but it goes into the details of editing
Input Actions.

Go to [03-create-a-character-motioninput-component.md](./03-create-a-character-motioninput-component.md)

--------------------------------------------------------

### 4 - Writing code that moves the character due to input values.

In section 3, we figured out how to receive input events in code, from Actions.
Here we write a `MotionController` component that works with the `MotionInput` component.

Go to [04-extend-motioninput-and-add-controller.md](./04-extend-motioninput-and-add-controller.md)

This completes the initial Quick Start and anything beyond this is an extension.


