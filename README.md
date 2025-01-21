# Design Patterns
A repo for studying design patter in C#

## Strategy Pattern
The strategy pattern is one of the most common design patter.

The strategy pattern can be identified by three different characteristics: 
- Context - has a reference to strategy and invokes it.
- IStrategy - defines the interface for the given strategy.
- Strategy - a concrete implementation of the strategy.

![alt text](img/strategy_pattern.png)

## NullObjectPattern
- Null referencing issue cost staggering amounts of time and money 
- Each Null check increases cyclomatic complexity - a measure of the number of the logical branches

![alt text](img/null_object_pattern.png)