#1 Prints 5
def number_of_food_groups():
    return 5
print(number_of_food_groups())


#2 Spits out error because there is a call to a function that does not exist
def number_of_military_branches():
    return 5
print(number_of_days_in_a_week_silicon_or_triangle_sides() + number_of_military_branches())


#3 Prints 5 because a return ends the function so the 1st return will be the one that prints
def number_of_books_on_hold():
    return 5
    return 10
print(number_of_books_on_hold())


#4 Prints 5 because a return ends the function so the 1st return will be the one that prints
def number_of_fingers():
    return 5
    print(10)
print(number_of_fingers())


#5 Prints 5 and then prints none because the function lacks a return statement
def number_of_great_lakes():
    print(5)
x = number_of_great_lakes()
print(x)


#6 prints out 3 and 5 but doesn't sum the numbers because the values dont exist since the function lacks a return statement
def add(b,c):
    print(b+c)
print(add(1,2) + add(2,3))


#7 Prints 25 since there is no space between
def concatenate(b,c):
    return str(b)+str(c)
print(concatenate(2,5))


#8 i will return either the if or the else contents. After that, the return afte the if won't get read
def number_of_oceans_or_fingers_or_continents():
    b = 100
    print(b)
    if b < 10:
        return 5
    else:
        return 10
    return 7
print(number_of_oceans_or_fingers_or_continents())


#9 Will return only whats in between if or else indents. 1st result is 7, 2nd is 14, and last is 21
def number_of_days_in_a_week_silicon_or_triangle_sides(b,c):
    if b<c:
        return 7
    else:
        return 14
    return 3
print(number_of_days_in_a_week_silicon_or_triangle_sides(2,3))
print(number_of_days_in_a_week_silicon_or_triangle_sides(5,3))
print(number_of_days_in_a_week_silicon_or_triangle_sides(2,3) + number_of_days_in_a_week_silicon_or_triangle_sides(5,3))


#10 Will return 8. 10 is unreachable
def addition(b,c):
    return b+c
    return 10
print(addition(3,5))


#11 prints 500 twice then prints 300 then 500 again
b = 500
print(b)
def foobar():
    b = 300
    print(b)
print(b)
foobar()
print(b)


#12 prints 500 twice then prints 300 once and then 500 again
b = 500
print(b)
def foobar():
    b = 300
    print(b)
    return b
print(b)
foobar()
print(b)


#13 prints 500 twice, 300 twice, then 500 once more
b = 500
print(b)
def foobar():
    b = 300
    print(b)
    return b
print(b)
b=foobar()
print(b)


#14 Prints 1 then 3 then 2
def foo():
    print(1)
    bar()
    print(2)
def bar():
    print(3)
foo()


#15 prints 1, then 3, then 5, then 10
def foo():
    print(1)
    x = bar()
    print(x)
    return 10
def bar():
    print(3)
    return 5
y = foo()
print(y)