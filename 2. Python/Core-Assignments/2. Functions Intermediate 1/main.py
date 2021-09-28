def update_vals():
    x = [[5, 2, 3], [10, 8, 9]]
    x[1][0] = 15
    students = [
        {'first_name': 'Michael', 'last_name': 'Jordan'},
        {'first_name': 'John', 'last_name': 'Rosales'}
    ]
    sports_directory = {
        'basketball': ['Kobe', 'Jordan', 'James', 'Curry'],
        'soccer': ['Messi', 'Ronaldo', 'Rooney']
    }
    # Change Last name or Student Jordan to Bryant
    students[0]["last_name"] = "Bryant"
    # Change Directory name Messi to Andres
    sports_directory['soccer'][0] = "Andres"

    # Change Y Value to 30
    z = [{'x': 10, 'y': 20}]
    z[0]['y'] = "30"

    print(students)
    print(sports_directory)
    print(z)


students = [
    {'first_name': 'Michael', 'last_name': 'Jordan'},
    {'first_name': 'John', 'last_name': 'Rosales'},
    {'first_name': 'Mark', 'last_name': 'Guillen'},
    {'first_name': 'KB', 'last_name': 'Tonel'}
]


def iterateDictionary(some_list):
    count = 0
    for count in range(0, len(some_list)):
        print("first_name - " + some_list[count]['first_name'] + ", last_name - " + some_list[count]['last_name'])


def iterateDictionary2(key_name, some_list):
    count = 0
    for count in range(0, len(some_list)):
        print(some_list[count][key_name])


dojo = {
    'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
    'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}

def printInfo(some_dict):
    count = 0
    print(len(some_dict['locations']), "Locations")
    for count in range(0,len(some_dict['locations'])):
        print(some_dict['locations'][count])

    print("")
    count = 0
    print(len(some_dict['instructors']), "Instructors")
    for count in range(0,len(some_dict['instructors'])):
        print(some_dict['instructors'][count])

