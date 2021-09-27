def revnum(num):
    list = []
    for num in reversed(range(0, num + 1)):
        list.append(num)
    return list


print(revnum(5))


def printfirst_returnsecond(list):
    print(list[0])
    return list[1]


print(printfirst_returnsecond([1, 2]))


def first_plus_length(list):
    return len(list) + list[0]


print(first_plus_length([1, 2, 3, 4, 5, 6]))


def values_greater_than_the_second(list):
    bool = False
    count = 0
    nlist = []

    if len(list) < 2:
        return bool

    for count in range(0, len(list)):
        if list[count] > list[1]:
            nlist.append(list[count])
    print(nlist)


print(values_greater_than_the_second([5, 2, 3, 2, 1, 4]))



def length_nd_value(num1, num2):
    count = 0
    li = []
    for count in range(0,num1):
        li.append(num2)

    return li


print(length_nd_value(6,2))