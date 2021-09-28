class User:
    def __init__(self, name, email):
        self.user = name
        self.email = email
        self.account = BankAccount(int_rate=0.02, balance=0)

    def makeDeposit(self, amount):
        self.account.deposit(amount)

    def make_withdrawal(self, amount):
        self.account.withdraw(amount)

    def display_user_balance(self):
        self.account.display_account_info()

    def transfer_money(self, User, amount):
        self.make_withdrawal(amount)
        User.makeDeposit(amount)
        self.display_user_balance()
        User.display_user_balance()


class BankAccount:
    # don't forget to add some default values for these parameters!
    def __init__(self, int_rate, balance):
        self.intrate = int_rate
        self.bankbal = balance

    def deposit(self, amount):
        self.bankbal += amount
        return self

    def withdraw(self, amount):
        if self.bankbal - amount <= 0:
            print("Insufficient Funds: Charging a $5 fee")
            self.withdraw(5)
        else:
            self.bankbal -= amount
        return self

    def display_account_info(self):
        print("Balance:", self.bankbal)

    def yield_interest(self):
        balance = self.bankbal
        interest = self.intrate
        product = self.bankbal * self.intrate

        if self.bankbal > 0:
            self.bankbal += product
        else:
            print("Balance too low to apply interest")
        return self

shit = User("Alex","Shit@gmail.com")


shit.account.display_account_info()