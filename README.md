# Adapter Design Pattern

## Concept

As per the gang of four definition adapter design pattern "Match interfaces of different classes"

In software engineering adapter pattern allows the incompatible class to interact with the existing class by converting the interface of one class into an interface expected by the client. Adapter pattern help to reuse the existing functionality as it is a bridge between two incompatible interfaces.

Adapters coverts the interface of one class into an interface a client expects

## Real-life example

Let's take a real-life example, Travelling internationally with electronic devices has become so common and the power plug and socket standard are different in different countries so you need an adapter to convert the shape of your home power plugs to the shape of the outlets in the region of the world you are traveling to.

## Scenario (Code Implementation)

We have a product display service that can be display product from two different sources one using file and another by calling the vendor API
