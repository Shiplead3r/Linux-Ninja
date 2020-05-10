# Remove the permission from U, G and O
$ chmod -x file1

# Apply Permission to the folder and all files inside it
$ chmod -R +x folder1

/*
 Permissions Files VS Folders
        [Files]      [Folders]
 r      Read File    ls

 w      Edit,Delete  Add,Delete

 x      Execute     cd, ls -l
*/


# Now If we have a read permission only this is the allowed operations
# only that you can do
[shipmast3r@localhost Desktop]$ ls -la
total 4
drwxr-xr-x.  4 root root   50 May 10 11:19 .
dr-xr-x---. 19 root root 4096 May 10 20:44 ..
dr--r--r--.  2 root root   19 May 10 20:44 dir1

[shipmast3r@localhost Desktop]$ ls dir1/
ls: cannot access dir1/file1: Permission denied
file1


# As you can see here we cannot read the details because
# that's require execute permission x *
[shipmast3r@localhost Desktop]$ ls -la dir1
ls: cannot access dir1/.: Permission denied
ls: cannot access dir1/..: Permission denied
ls: cannot access dir1/file1: Permission denied
total 0
d????????? ? ? ? ?            ? .
d????????? ? ? ? ?            ? ..
-????????? ? ? ? ?            ? file1


# Also we cannot cd into this directory that's require execute permission
[shipmast3r@localhost Desktop]$ cd dir1/
bash: cd: dir1/: Permission denied


# If we have execute permission only we can cd into it
# but cannot list the files
[root@localhost Desktop]# chmod a+x,a-r dir1/
[root@localhost Desktop]# su shipmast3r
[shipmast3r@localhost Desktop]$ ls -la
total 4
drwxr-xr-x.  4 root root   50 May 10 11:19 .
dr-xr-x---. 19 root root 4096 May 10 20:44 ..
d--x--x--x.  2 root root   19 May 10 20:44 dir1
drwxr-xr-x.  2 root root  112 Apr 29 12:45 Metro.PerformanceTesting

[shipmast3r@localhost Desktop]$ cd dir1/
[shipmast3r@localhost dir1]$ ls
ls: cannot open directory .: Permission denied


# [!!] In this case If we have the read permission without execute permission
# we can still execute it using bash command because it read the file
# then execute the text that inside it also python scripts works fine
# with read permission
[root@localhost Desktop]# ls -la dir1/
total 4
d--x--x--x. 2 root root 19 May 10 20:44 .
drwxr-xr-x. 4 root root 50 May 10 11:19 ..
-rwxr-xr--. 1 root root 13 May 10 20:44 file1

[shipmast3r@localhost dir1]$ bash file1
ls: cannot open directory .: Permission denied
Sun May 10 21:11:01 EET 2020
      May 2020
Su Mo Tu We Th Fr Sa
                1  2
 3  4  5  6  7  8  9
10 11 12 13 14 15 16
17 18 19 20 21 22 23
24 25 26 27 28 29 30
31
[shipmast3r@localhost dir1]$ ./file1
bash: ./file1: Permission denied
