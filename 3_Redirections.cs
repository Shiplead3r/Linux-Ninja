# =============================================================================
# =============================== Author ======================================
#=============================== Shipmast3r ===================================
# =============================================================================

# Redirect output 1> OR >
[root@localhost home]# ls > result.txt

# Redirect output with append result to the file
[root@localhost home]# ls >> result.txt

# Redirect Error with appending the result
[root@localhost home]# ls 2>> result.txt

# Redirect both output and Error to two seprate files
[root@localhost home]# ls [>|>>] result.txt [2>|2>>] error.txt

# Redirect input to keyboard until shipmast3r word with appending
[root@localhost home]# cat <<shipmast3r>> test.txt
> Hello world
> and all of the people is happy
> shipmast3r

[root@localhost home]# cat test.txt
Hello world
and all of the people is happy

# Redirect input until eof with not appending the result
# << The Direction to append the input and then redirect it > to output without appending
[root@localhost home]# cat <<eof> result.txt
> Hello Text
> eof
[root@localhost home]# cat result.txt
Hello Text

=============================================================================
