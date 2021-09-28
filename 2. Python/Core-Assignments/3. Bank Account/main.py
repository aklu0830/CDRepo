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


acc_1 = BankAccount(0.0003, 400)
acc_2 = BankAccount(0.0003, 600)

acc_1.deposit(300).deposit(100).deposit(500).withdraw(200).yield_interest().display_account_info()
acc_1.deposit(300).deposit(1500).withdraw(200).withdraw(200).withdraw(200).withdraw(200).yield_interest().display_account_info()
