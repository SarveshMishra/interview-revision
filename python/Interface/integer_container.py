from abc import ABC

class IntegerContainer(ABC):
    """
    An abstract base class for containers that hold integer values.
    """

    def __init__(self):
        super().__init__()

    def add(self, value: int) -> int:
        """
        Add an integer to the container, and return the length of the updated container.
        """
        raise NotImplementedError("This method should be overridden by subclasses.")

    def delete(self, value: int) -> bool:
        """
        Should attempt to delete the given integer from the container. if found remove it and return True, otherwise return False.
        """
        raise NotImplementedError("This method should be overridden by subclasses.")