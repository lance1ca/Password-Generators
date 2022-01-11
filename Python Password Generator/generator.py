# Lance Rogan
# This is a simple Python Program that creates a random password based on user input

# import proper packages
import random
import string

# ask for user input and store appropriately
characters = (int)(input("How many characters would you like in your password? "))
specialCharacters = (int)(input("How many special characters would you like in your password? "))
numbers = (int)(input("How many numbers would you like in your password? "))

# initialize a list called password
password = list()

# this function generates and returns a random letter 
def random_letter():
    randomLetter = random.choice(string.ascii_letters)
    return randomLetter

# this function generates and returns a random special character/punctuation symbol
def random_specialCharacter():
    randomSpecialCharacter = random.choice(string.punctuation)
    return randomSpecialCharacter

# this function generates and returns a random number
def random_number():
    # we could also do this: randomNumber = random.randint(0,9)
    randomNumber = random.choice(string.digits)
    return randomNumber


#These loops iterate through the number of characters, special characters, and numbers
# and adds the randomly generated items to the password list
for c in range(characters):
    password += random_letter()

for c in range(specialCharacters):
    password += random_specialCharacter()

for c in range(numbers):
    password += random_number()

#shuffle the list
random.shuffle(password)
print("Great! Your password is: ", end="")
#loop through and print out the user password back to the user
for i in range(len(password)):
    print (password[i], end="")