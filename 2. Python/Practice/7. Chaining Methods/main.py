class User:
    def __init__(self, name, email):
        self.user = name
        self.email = email
        self.account_balance = 0

    def makeDeposit(self, amount):
        self.account_balance += amount
        return self

    def make_withdrawal(self, amount):
        self.account_balance -= amount
        return self

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

usr_one.makeDeposit(300).makeDeposit(700).makeDeposit(400).make_withdrawal(200).display_user_balance()

usr_two.makeDeposit(300).makeDeposit(400).make_withdrawal(100).make_withdrawal(50).display_user_balance()

usr_three.makeDeposit(4000).make_withdrawal(200).make_withdrawal(300).make_withdrawal(700).display_user_balance()

print("")
print("Transfer:")
print("")

usr_one.transfer_money(usr_three, 200)