# RockPaperScissorsGame
 Rock Paper Scissors Game in Windows Application environment using C# language
🪨 🧻 ✂️

Rock, Paper, and Scissors are represented for the complier as 1, 2, and 3 respectively.

Each time when one of three buttons is pressed Method Game() is executed

Method Game() takes one integer variable which is either 1 or 2 or 3.
There is a variable pcMove which takes a random number form 1, 4 (4 is excluded). 
It is used to give the computer a choice between rock, paper, or scissors.

Then, this method the if statement comapares which button was pressed and which number computer generated.

if numbers are the same, it is a Draw
Following these rules: 
![image](https://user-images.githubusercontent.com/41874992/208255343-64dd5811-ac10-4153-b4fc-cfe6dc757b77.png)
the winner is determined if the overall number of wins is equal to or becomes greater than Winning score. 
By default it is set to 5, so in order to win the total amount of wins should rich the winning score 

ListBox is used as a status bar. It was used to check for any compled code errors. 


