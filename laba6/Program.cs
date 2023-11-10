using System.Collections.Generic;

from typing import List
class Vehicle : def __init__(self, speed: float, capacity: int):
        self.speed = speed        self.capacity = capacity
    def move(self):
        pass
class Human :
    def __init__(self, speed: float):        self.speed = speed
    def move(self):
        pass
class Car(Vehicle) : def __init__(self, speed: float, capacity: int, fuel_type: str):
        super().__init__(speed, capacity)        self.fuel_type = fuel_type
    def move(self):
        print("Car is moving")
class Bus(Vehicle) : def __init__(self, speed: float, capacity: int, route_number: str):
        super().__init__(speed, capacity)        self.route_number = route_number

    def move(self):        print("Bus is moving")
class Train(Vehicle) :
    def __init__(self, speed: float, capacity: int, train_number: str):        super().__init__(speed, capacity)
        self.train_number = train_number
    def move(self):        print("Train is moving")
class Route :
    def __init__(self, start_point: str, end_point: str):        self.start_point = start_point
        self.end_point = end_point
class TransportNetwork : def __init__(self):
        self.vehicles = []
    def add_vehicle(self, vehicle: Vehicle):        self.vehicles.append(vehicle)
    def calculate_optimal_route(self, route: Route, vehicle_type: type):
        # Add logic to calculate optimal route based on the vehicle type        pass
    def embark_disembark_passengers(self, vehicle: Vehicle):
        # Add logic for passenger boarding and disembarking        pass