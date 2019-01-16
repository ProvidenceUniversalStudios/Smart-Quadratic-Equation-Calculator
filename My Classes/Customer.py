class Customer:
    def __init__(self, Name, PNo, Airtime, SMS, Data):
        self.Name = Name
        self.PNo = PNo
        self.Airtime = Airtime
        self.SMS = SMS
        self.Data = Data

    def read(self):
        self.Name = input("Enter the Name ")
        self.PNo = input("Enter the Phone Number ")
        self.Airtime = input("Enter the Airtime Balance ")
        self.SMS = input("Enter the SMS Balance ")
        self.Data = input("Enter the Data Balance ")

    def Print(self):
        print("The Name of the Customer is ", self.Name)
        print("The Phone Number of the Customer is ", self.PNo)
        print("The Airtime Balance of the Customer is ", self.Airtime)
        print("The SMS Balance of the Customer is ", self.SMS)
        print("The Data Balance of the Customer is ", self.Data)

    def balance(self):
        print("The Airtime Balance of the Customer is ", self.Airtime)
        print("The SMS Balance of the Customer is ", self.SMS)
        print("The Data Balance of the Customer is ", self.Data)

    def recharge(self, is5):
        if is5 == true:
            self.Airtime += 5
        else:
            self.Airtime += 1
	print("Your airtime balance is now ", self.Airtime)

myCust = Customer()
myCust.recharge(true)
