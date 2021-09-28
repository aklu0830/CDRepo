class User:
    def __init__(self, name, email):
        self.user = name
        self.email = email
        self.account_balance = 0

    def makeDeposit(self, amount):
        self.account_balance += amount

    def make_withdrawal(self, amount):
        self.account_balance -= amount

    def display_user_balance(self):
        print("User:", self.user + ",", "Balance:", self.account_balance)

    def transfer_money(self, User, amount):
        self.make_withdrawal(amount)
        User.makeDeposit(amount)
        self.display_user_balance()
        User.display_user_balance()


usr_one = User("One", "trolls@codingdojo.com")
usr_two = User("Two", "trolls@codingdojo.com")
usr_three = User("Three", "trolls@codingdojo.com")

usr_one.makeDeposit(300)
usr_one.makeDeposit(700)
usr_one.makeDeposit(400)
usr_one.make_withdrawal(200)
usr_one.display_user_balance()

usr_two.makeDeposit(300)
usr_two.makeDeposit(400)
usr_two.make_withdrawal(100)
usr_two.make_withdrawal(50)
usr_two.display_user_balance()

usr_three.makeDeposit(4000)
usr_three.make_withdrawal(200)
usr_three.make_withdrawal(300)
usr_three.make_withdrawal(700)
usr_three.display_user_balance()

print("")
print("Transfer:")
print("")

usr_one.transfer_money(usr_three, 200)

