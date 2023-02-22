
# RPG Heroes console application
A console application built using .Net to play a RPG Game. Tested using xUnit test.

## Features
It contains various hero classes having attributes which increase at different rates as the character gains levels.
Equipment, such as armor and weapons, that characters can equip. The equipped items will alter the power of 
the hero, causing it to deal more damage with wepons and be able to survive longer in case of equiping armor. Certain heroes can equip certain item 
types.

Custom exceptions. There are two custom exceptions for invalid wepon and invalid armor.
Diffrent Classes of Heros can hold diffrent kinds of armor and wepons and get a invalid exception when trying to equip the wrong kind. 
If the Hero is not at the requierd level for the armor or wepon then a invalid exception is also thrown. 

Unit testing is to verify the behavior of Heroes. This is also how the project is “run”.
The tests cover all the public facing methods of the Heroes as well as 
any functionality used in those processes.

## Requirements
- Visual Studio with .NET 6
- Git
- xUnit

##

This project was generated with .NET 6 and tested with xUnit tests

