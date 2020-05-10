# Add New User
$ useradd username

# add user to secondry group
$ usermod -aG secondry_group

#Change the primary group
$ usermod -g group user

# Change the secondry group 

#Change the primary group for the user while creating it
$ useradd -g primary_group username

# Delete user without deleting its files
$ userdel user_name

#Delete The user with his home files
$ userdel -r user_name

// In All user commands the order is [group] [user]

