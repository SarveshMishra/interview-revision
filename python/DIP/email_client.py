from abc import ABC

class EmailClient(ABC):
    '''
    Interface to email sending mechanism
    '''
    def __init__(self):
        super().__init__()

    def sendEmail(self,to: str, subject: str, body: str)-> bool:
        """
        Send Email using client
        """
        raise NotImplementedError(
            "This method should be overridden by subclasses.")
