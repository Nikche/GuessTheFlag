# Guess The Flag


A C# Windows Forms project by: Nikola Vasilevski.

##1. Опис на апликацијата
Во овој проект е имплементирана играта Guess the Flag, со додавање на уште еден начин на играње **Inverted Mode**

##2. Упатство за користење

###2.1 Нова игра/New Game

![Main Menu](images/main-menu.PNG)

На почетното мени при стартување на апликацијата може да започнете нова игра со кликање на копчето **New Game**, каде што се отвара нов прозорец во кој вие си бирате начинот на играње.

###2.2 Поставки/Settings

![Settings](images/settings.PNG)

Во овој прозорец имате можност да изберете левел на кој ќе играте односно тежина. Имате 3 опции:
**Easy/Лесна**
**Medium/Средна**
**Hard/Тешка**. 

Потоа имате можност да селектирате еден од два понудени начини на играње:

**Classic Game**
**Inverted Game**

## How to Play

- Guess the correct country that is being displayed on the screen.
- Each game lasts 60 seconds.
- Each correct answer updates your total score.
- Wrong answers do not subtract from the total score.
- A sound is played whether you guessed correctly or not.
- A label in the top-left corner tracks total correct answers.
- A label in the top-right corner shows how much time you have left.

---

## Game Modes

### Classic Mode

- One random country **flag** is displayed on the screen.
- 4 buttons appear: 1 correct answer and 3 incorrect ones.
- If you guess correctly:
  - A sound is played.
  - The button turns green.
- If you guess incorrectly:
  - A different sound is played.
  - The button turns red.

### Inverted Mode

- One random **country name** is displayed on the screen.
- 4 flags are shown: only 1 is correct.
- Correct and incorrect guesses trigger different sounds.

---

## Bonus Mode – Survival

- Can be enabled alongside any game mode.
- You start with **3 lives**.
- Each wrong guess removes **1 life**.
- Game ends when you lose all 3 lives.

---

## Tutorial

### Start Menu

- Click **New Game** to start playing.  
  ![Main Menu](images/main-menu.PNG)

### Classic Mode

- A flag will appear on the screen.  
- Select the correct country name from the four buttons.  
- Correct guesses play a positive sound and highlight the button green.  
- Wrong guesses play a different sound and highlight the button red.  
  ![Classic Mode](images/classic-game.PNG)

### Inverted Mode

- A country name is shown instead of a flag.  
- Choose the correct flag from four options.  
- Sounds and button highlights work the same as Classic Mode.  
  ![Inverted Mode](images/inverted-game.PNG)

### Settings

- Access settings from the main menu to toggle game modes and enable Survival mode.  
  ![Settings](images/settings.PNG)


## Credits

Created by **Nikola Vasilevski**
