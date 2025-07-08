from integer_container import IntegerContainer


class IntegerControllerImpl(IntegerContainer):

    def __init__(self):
        super().__init__()
        self._container = []

    def add(self, value: int) -> int:
        self._container.append(value)
        return len(self._container)

    def delete(self, value: int) -> bool:
        try:
            self._container.remove(value)
            return True
        except ValueError:
            return False

    def get_median(self) -> int:
        '''
        Return the median of the after container is sorted in ascending order. If even number return the left most of the two middle values. If empty return None.
        '''
        if not self._container:
            return None
        self._container.sort()
        mid = len(self._container) // 2
        if len(self._container) % 2 == 1:
            return self._container[mid]
        return self._container[mid - 1]