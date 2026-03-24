This project is a console application in C# simulating a university equipment rental system. It manages users, equipment, and rentals, including availability tracking, rental limits, and penalties for late returns.

The domain model includes an abstract Equipment class with derived types Laptop, Projector, and Camera, a User class with Student and Employee types, and a Rental class that tracks rental dates and calculates penalties. Business logic is implemented in the RentalService class, which enforces user limits, equipment availability, and late return penalties. The IRentalService interface defines the service contract.

Data is stored in a Singleton class representing an in-memory database.