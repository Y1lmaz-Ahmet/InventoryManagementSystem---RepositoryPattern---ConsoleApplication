# Inventory Management System

Welcome to the Inventory Management System! This is a simple console application implemented in C# using the repository pattern.

## Overview

The Inventory Management System allows users to manage products by performing CRUD operations (Create, Read, Update, Delete) through a user-friendly console interface.

## Design Pattern

This project follows the **Repository Pattern**, a design pattern commonly used in software development to separate the logic that retrieves data from a data source from the business logic of the application. This promotes a clean separation of concerns and improves maintainability and testability.

## Classes

### Product
The `Product` class represents an individual product in the inventory. It contains properties such as ID, name, description, price, and stock, along with methods for updating product details.

### ProductRepository
The `ProductRepository` class implements the repository pattern and serves as the interface between the application and the data source (in-memory list of products). It provides methods for adding, removing, updating, and retrieving products from the repository.

#### Methods

- **AddProduct(Product product)**: Adds a new product to the repository.

- **RemoveProduct(int productId)**: Removes a product from the repository based on its ID.

- **GetProductById(int productId)**: Retrieves a product from the repository based on its ID.

- **UpdateProduct(Product updatedProduct)**: Updates the details of an existing product in the repository.

## Object-Oriented Programming (OOP) Concepts

This project demonstrates several key concepts of Object-Oriented Programming:

- **Encapsulation**: Properties of the `Product` class are encapsulated with private fields and public getters/setters, ensuring data integrity and providing controlled access to the object's state.

- **Inheritance**: While not explicitly demonstrated in this project, inheritance could be used if there were multiple types of products with shared attributes and behaviors.

- **Polymorphism**: Polymorphism allows objects of different types to be treated as objects of a common base type. This concept is not heavily used in this project but could be applied in more complex scenarios.

## Interfaces

The project also makes use of interfaces:

### IProductRepository
The `IProductRepository` interface defines the contract for classes that implement product repository functionality. It includes methods for adding, removing, updating, and retrieving products.

