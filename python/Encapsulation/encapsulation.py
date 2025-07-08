class BankAccount:
    '''
    Class to encapsulate the BankAccount methods
    '''

    def __init__(self, account_holder: str, balance: int,):
        self.__account_holder = account_holder # Private Variable
        self.__balance = balance # Private Variable

    # Getter Method to access balance
    def get_balance(self) -> int:
        return self.__balance

    # Setter method to modify the balance
    def deposit(self, amount) -> None:
        if amount > 0:
            self.__balance += amount
            print(f"Amount deposited, final balance {self.__balance}")
        else:
            print("Invalid amount")

    def get_account_holder(self) -> str:
        return self.__account_holder




account = BankAccount('Sarvesh', 100000)

account_holder = account.get_account_holder()
print(account_holder)
amount = account.get_balance()
print(amount)
account.deposit(400)


