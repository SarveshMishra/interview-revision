from parking_lot import ParkingLot
from level import Level
from car import Car
from motorcycle import MotorCycle
from truck import Truck


class Main:
    def run():
        parking_lot = ParkingLot.get_instance()
        parking_lot.add_level(Level(1, 5))
        parking_lot.add_level(Level(2, 4))

        car = Car("ABC123")
        truck = Truck("XYZ789")
        motorcycle = MotorCycle("M1234")

        # Park vehicles
        print("Parking 3 vehicle")
        parking_lot.park_vehicle(car)
        parking_lot.park_vehicle(truck)
        parking_lot.park_vehicle(motorcycle)

        # Display availability
        print("Spots after parking")
        parking_lot.display_availability()

        # Unpark vehicle
        print("Unpark one motorcycle")
        parking_lot.unpark_vehicle(motorcycle)

        # Display updated availability
        print("Updated availability")
        parking_lot.display_availability()


if __name__ == "__main__":
    Main.run()
