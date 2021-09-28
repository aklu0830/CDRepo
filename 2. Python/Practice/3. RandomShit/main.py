class User:
    bank = 0

    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.accountbal = 0

    def depmoney(self, cash):
        self.accountbal += cash


monty = User("shit", "fork@mopsweeping.com")

print(monty.name)
monty.depmoney(400)
print(monty.accountbal)
