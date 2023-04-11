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
    
"""Week_10 Exercise_1"""
#Create a function called team_collaboration().
#pass two team collaboration software names as the arguments. 
#The function should print "I use ------- software for team collaboration "

def team_collaboration(software_first, software_second):
    print(f"I use {software_first} and {software_second} software for team collaboration.")
    
team_collaboration("Teams", "Github")

"""Week_10 Exercise_2"""
#Create a function called project() that store project_id globally and locally.
#Call the function and display both the id's . 
#Print the statement as 
#"My global project id is :"
#"My internal project id is :"

project_id = 11
def project():
    #Creating porject id as a global variale inside a function
    global project_id
    project_id = 1
    print(f"My local project id is {project_id}")
    
print(f"My global project id is {project_id}")
project()

"""Week_11 Exercise_1"""
#Import the correct library and print a calendar for your project. 
#Print October month calendar of this year 
#sample output as follows :

import calendar

print(calendar.month(2021, 8))

"""Week_11 Exercise_2"""
#Use 5 Functions in Python Math Module  and print the results

import math
num1= 2
num2 = 5

sine = math.sin(num1)
cose = math.cos(num1)
power = math.pow(num1, num2)
factorial = math.factorial(num2)
root = math.sqrt(num1)

print(f"The sin of {num1} is {sine}")
print(f"The cos of {num1} is {cose}")
print(f"The power of base {num1} to {num2} is {power}")
print(f"The factorial of {num2} is {factorial}")
print(f"The square root of {num1} is {root}")

"""Week_12 Exercise_1"""
#using OSmodule , explore the following functions  and execute the command 
#1. Write a command to create a new directory using OS Library 
#2. Write a command to delete the existing file

import os
new_directory = 'my_directory_directory'
#0o755 gives permission for reading, writing the directory
os.mkdir(new_directory, 0o755)

os.remove('new_directory')

"""Week_12 Exercise_2"""
#using Pandas library , produce the following output.
#using pandas data frame organize the data into rows and columns.

import pandas as pd
data = {
        'subject_id' : [1, 2, 3, 4],
        'student_name' : ['Joseph', 'Eva', 'Kevin', 'Joseph'],
        'courses' : ['software engineering', 'Artificial Intelligence', 'Gaming', 'Software Engineering Technician']
        }

print(pd.DataFrame(data))