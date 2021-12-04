import requests

# The Action Page URL
url = 'path_to_post.php'

# The data to send
mydata = {
    'name': 'John Doe',
    'email': 'randomemail@random.xxx',
    'message': 'my random message'
}

# The Loop that Does the Magic
i = 0
while (i < 500000):
    x = requests.post(url, data=mydata)
    if (x):
        print("sent #" + str(i) + "\n")
    i += 1