#Program pro výpočet potenciální energie
print("Vítejte! Umím vypočítat potenciální energii tělesa")
hmotnost=float(input("Zadejte hmotnost tělesa"))
vyska=float(input("Zadejte výšku, ve které je těleso"))
zrychleni=10
energie=hmotnost*zrychleni*vyska
print("Energie tělesa je",energie,"J")
input()
