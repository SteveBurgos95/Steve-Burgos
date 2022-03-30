# Shell Programming

<details><summary>HISTORY OF LINUX AND SHELL</summary>

## **History of Linux and Shell**

* Linux first created in 1991 as a project to create a free operating system by Finnish student Linus Torvalds.
* It is now over 23 million lines of code under the General public license.
* Resembled the minix system in the file layout, and became popularized with the porting of X Window System GUI.
* Originally named Freax and changed to Linux and the mascot is a penguin.
* The largest part of the work on Linux is performed by the community.

### **Shell**

* In 1971 Ken Thompson released the first Unix shell-the Thompson shell.
* In 1977 Stephen Bourne released the Bourne shell, meant to solve the scripting limitations of the Thompson shell.
* In 1989 Brian Fox released the Bourne-Again shell (Bash), in order to create a competitive and free software.
* Bash became the main open source scripting language as Linux became the primary open source operating system.
</details>
<br></br>
<details><summary>INTRODUCTION TO THE BASH SHELL</summary>

## **Introduction to the Bash Shell**
A command line is a text user interface. One can use such an interface to provide instructions to a Linux Power computer. Our text user interfeace is GitBash
* Developed by [GNU](https://bash.cyberciti.biz/guide/GNU) project
* The default Linux shell on most Linux distributions
* Backward-compatible with the original sh UNIX shell
* The ```$``` is the command line prompt when bash is waiting for a command from the user. We typically call this the command prompt or shell prompt. If you are a root user the default prompt will be ```#```
<br></br>
### **Shell Commands**
There are two types of commands for bash shell
* Internal commans(builtins) = part of the shell itself
* External commands - seperate binaries stored in /sbin, /usr/sbin, /usr/bin, /bin, or /usr/local/bin directories

We need to execute commands using these three parts

1. The command
2. Options that typically start with a ```-``` or ```--```
3. Argument

The Bash shell understands the following commands:

* **Aliases** such as ```ll```
* **Keywords** such as ```if```
* **Functions**
* **Built in** such as ```pwd```
* **Files** such as ```/bin/date```

</details>
<br></br>
<details><summary>THE SHELL VARIABLES AND ENVIRONMENT</summary>

## **The Shell Variables and Environment**
### **System Variables**
Created and maintained by Linux bash shell itself. This type of variable (with the exception of auto_resume and histchars) is defined in CAPITAL LETTERS. You can configure aspects of the shell by modifying system variables such as PS1, PATH, LANG,HISTSIZE,and DISPLAY etc.
### **User Defined Variables**
Created and maintained by user. This type of variable defined may use any valid variable name, but it is good practice to avoid all uppercase names as many are used by the shell.
### **How to configure and customize the Bash shell environment**
* Variables: You can use variables to store data and configuration options
* Set Command:  A built-in Linux shell command that displays and sets the names and values of shell and Linux environment variables
* Shopt Command: Provides control over many settings that are used to tweak the operations in a Bash shell
* Functions: Set of commands
* Alias: An alias is nothing but shortcut to commands

### **What should I put in shell startup files for customization**
* Setup a custom prompt.
* Setup terminal settings depending on which terminal you're using.
* Set the search path such as JAVA_HOME, and ORACLE_HOME.
* Set environment variables as needed by programs.
* Run commands that you want to run whenever you log in or log out.
<br></br>

## **Common System Variables**
| System Variable | Meaning                                               | To View Variable Value Type |
|:---             | :---                                                  | :---                        |
|BASH_VERSION     |Holds the version of this instance of bash             |	echo $BASH_VERSION              |
|HOSTNAME         |The name of the your computer.                         |	echo $HOSTNAME        |
|CDPATH    |The search path for the cd command.            |echo $CDPATH         |
|HISTFILE     |The name of the file in which command history is saved.             |echo $HISTFILE           |
|HISTFILESIZE    |The maximum number of lines contained in the history file.             |echo $HISTFILESIZE          |
|HISTSIZE    |The number of commands to remember in the command history. The default value is 500.             |echo $HISTSIZE          |
|HOME    |The home directory of the current user.             |echo $HOME          |
|IFS    |The Internal Field Separator that is used for word splitting after expansion and to split lines into words with the read builtin command. The default value is <space><tab><newline>.             |echo $IFS          |
|LANG    |Used to determine the locale category for any category not specifically selected with a variable starting with LC_.             |echo $LANG         |
|PATH    |The search path for commands. It is a colon-separated list of directories in which the shell looks for commands.             |echo $PATH          |
|PS1     |Your prompt settings.             |echo $PS1         |
|TMOUT    |The default timeout for the read builtin command. Also in an interactive shell, the value is interpreted as the number of seconds to wait for input after issuing the command. If not input provided it will logout user.             |echo $TMOUT          |
|TERM    |Your login terminal type.             |echo $TERM   export TERM=vt100           |
|SHELL    |Set path to login shell.             |echo $SHELL          |
|DISPLAY     |HSet X display name             |echo $DISPLAY   export DISPLAY=:0.1           |
|EDITOR    |Set name of default text editor.             |export EDITOR=/usr/bin/vim         |

<br></br>


</details>
<br></br>
References

https://bash.cyberciti.biz/guide/Main_Page

https://www.tutorialspoint.com/unix/shell_scripting.htm