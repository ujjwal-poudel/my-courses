"""Week_6 Exercise_1"""
#Question_1
#Here are my 3 favourites
print("Programming")
print("Web Desigining")
print("Artificial Intelligence")

#Question_2
#using variables to store student details
first_name = "Ujjwal"
last_name = "Poudel"
address = "100 Parkway Forest Drive, Toronto, Ontario"
print(f"\nHi I am {first_name} {last_name} and I reside in {address}\n")


"""Week_6 Exercise_2"""
#This software records the user who are active
active_users = ['jam', 'sam', 'juju', 'whocares', 'if', 'he', 'teaches', 'well']
active_users.pop() #removes the last element from the list by default
active_users.append('juju') #adds the given element in list in last index by default
print(active_users)#This is the modified list
print(active_users[0:5:2]) #This is the sliced list, skipping every second element


"""Week_6 Exercise_3"""
#Here the lists of course name you are enrolled in
courses = ['Comp100', 'Comp213', 'Gned400']

#using conditional statements to check the course title
course_name = input("Please enter your course name: ").capitalize()
if course_name in courses:
    print(f"{course_name} is available in first semester!")
else:
    print(f"{course_name} is not available in first semester.")

#using index to get the items in the list
print(f"\nyou are enrolled in {courses[0]}")
print(f"you are also enrolled in {courses[1]}")
print(f"The first course you are enrolled in is {courses[2]}")
courses.append('Comp216') #appendig a new course in the list
print(courses, "\n") #prints the modified list


"""Week_8 Exercise_1"""
#Question_1
favorite_languages = {
    'jen': 'HTML',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'C#',
    }

#Change the value from C# to Python for the key phil
favorite_languages["phil"] = "python"
#Add an item in the dictionary 
favorite_languages["ujjwal"] = "C++"
#Remove an item from the dictionary
favorite_languages.pop("edward")
#List all the values in the dictionary
print(favorite_languages.values(), "\n")


"""Week_8 Exercise_2"""
#create   a python dictionary called student.
#Include student name, age, subject, semester, grade and lab keys.
#Include the value for each key accordingly.
#Display keys separately and values separately in the print statement.

student = {
    'name': 'Juju Chan',
    'age': 19,
    'subject': 'Software-Engineering-Technology',
    'semester': 'First',
    'grade': 'A',
    'lab': '3'
    }

print(student.keys())
print(student.values())


"""Week_9 Exercise_1"""
#Write a program in python using if condition.
#Input the temperature (user input).
#check if the temperature is less than 98 display the result as cold.
#otherwise  if the temperature more than 98 , display the result as Hot.
#otherwise display them as normal. 

temperature = int(input("Enter the temperature: "))
if temperature > 98:
    print("HOT! Is this really Canada?\n")
    
elif temperature < 98:
    print("Cold! These cloths aren't enough.\n")
    
else:
    print("The temperature is normal.\n")
    
    
"""Week_9 Exercise_2"""
#Program to iterate agile values  through a list using indexing.
#create the following agile values in list.
#use for loop and iterate over the list:

agile_values = ['Individuals and interactions', 'Working software ', 'Customer collaboration ','Responding to change']
index_value = agile_values.index('Individuals and interactions')
print("Here are the following agile values:")
for values in agile_values:
    print(index_value, agile_values[index_value])
    index_value += 1