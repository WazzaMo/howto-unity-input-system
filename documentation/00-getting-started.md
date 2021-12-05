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

See [Section 1 - installation.md](./01-installation.md) for
an overview and link to Unity's installation guide - that guide is OK.

Then choose one of the two starting points below.

--------------------------------------------------------

### 2 - Making a basic Character

There are assets on the AssetStore for characters you could control.

Let's assume for the moment you want to make something rough and learn a bit
about setting up a scene in the process - that's what this is about.

Follow the instructions in [Section 3 - make-scene-and-character.md](./02-make-scene-and-character.md)
for detailed instructions on how to create a basic scene and
character. It's not pretty but it's enough to start with.

--------------------------------------------------------

### 3 - Configuring Input Actions and debugging them

Let's figure out how the Input System Actions turn into events received in C# code.
In this section we write a `MotionInput` controller and set up an Input Actions
asset and debug it. It's a long one but it goes into the details of editing
Input Actions.

Go to [Section 3 - create-a-character-motioninput-component.md](./03-create-a-character-motioninput-component.md)

--------------------------------------------------------

### 4 - Writing code that moves the character due to input values.

In section 3, we figured out how to receive input events in code, from Actions.
Here we write a `MotionController` component that works with the `MotionInput` component.

Go to [Section 4 - extend-motioninput-and-add-controller.md](./04-extend-motioninput-and-add-controller.md)

This completes the initial Quick Start and anything beyond this is an extension.

### 5 - Add extra keyboard bindings for Arrow Keys

In section 3, we defined keyboard bindings for **WASD** keys only, let's add
Arrow keys so we can use either set to control the same character.

Go to [Section 5 - Add Arrow Key mappings and test again.](./05-adding-arrow-keys.md)

### 6 - Add Playstation 4 Controller support

Adding to section 5's addition arrow key support, let's try a completely
different input device - the PS4 Dual Shock controller connected to PC via USB.

Go to [Section 6 - Add PS4 Dual Shock Controller support.](./06-ps4-controller.md)

----------------------------------------------------------------------
**NEXT**: [Make sure Input System is installed](./01-installation.md)
