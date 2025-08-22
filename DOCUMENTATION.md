# What is this thing?

This is a "game engine" written in C# using .NET 9 (i think)

it aims to be a simple and easy to use engine for 2D games (key word there, "aims")

## How do I use it? (Actually just explaining what ECS is first)
Before we cover "using it", we need to go over some stuff that i chose for the engine that you WILL follow

Firstly, the engine is ECS (Entity Component System) based 
What the hell is ECS? You ask? 
ECS is an architectural design choice from me that splits your game and the bits inside it into 3 main parts, entities, components and systems

Entities are the things in your game, aka a gameobject

Entities or gameobjects are made up of components. Components hold data to make up an entity, for example the position of your entitiy, a sprite and whatnot

Systems hold the logic for a component. In an ideal world, each component would have its own system and the components and systems basically love each other and dont care about anything else, we then slap one of these components onto an entity and hope it does something, the system shouldn't care about what the component is attached to, it should just work

## Setting up a project
talk to me when i figure this out thx
TODO: figure this out^



### misc
some other stuff is written in README.md, read that too!!

DOCUMENTATION.md will be for more in depth stuff when that indepth stuff exists