using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace The_Interesting_Day
{
    public partial class TheInterestingDay : Form
    {
        int page = 1;
        Random random = new Random();
        int number;

        public TheInterestingDay()
        {
            InitializeComponent();
            storyLabel.Text = "You are in your bed and you've just woken up. You are trying to decide whether to get up or sleep in some more.";
            questionLabel.Text = "Get up or sleep in?";
            firstOptionButton.Text = "Get up";
            secondOptionButton.Text = "Sleep in";
            thirdOptionButton.Text = "";
            firstOptionButton.Visible = true;
            secondOptionButton.Visible = true;
            thirdOptionButton.Visible = false;
            optionLabel.Text = "1\n2";
            pictureBox.Image = Properties.Resources.bed;
        }

        public void StoryOutput()
        {
            pictureBox.Image = null;
            firstOptionButton.Visible = false;
            secondOptionButton.Visible = false;
            thirdOptionButton.Visible = false;
            Refresh();
            Thread.Sleep(500);

            switch (page)
            {
                case 1:
                    storyLabel.Text = "You are in your bed and you've just woken up. You are trying to decide whether to get up or sleep in some more.";
                    questionLabel.Text = "Get up or sleep in?";
                    firstOptionButton.Text = "Get up";
                    secondOptionButton.Text = "Sleep in";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    pictureBox.Image = Properties.Resources.bed;
                    break;
                case 2:
                    storyLabel.Text = "You are hungry for breakfast.";
                    questionLabel.Text = "What do you want to eat?";
                    firstOptionButton.Text = "Bacon and eggs";
                    secondOptionButton.Text = "Waffles";
                    thirdOptionButton.Text = "Cereal";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = true;
                    optionLabel.Text = "1\n2\n3";
                    break;
                case 3:
                    storyLabel.Text = "You find the frozen waffles, toast them, and eat them. They were delicious.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    pictureBox.Image = Properties.Resources.waffles;
                    Refresh();
                    Thread.Sleep(2000);
                    page = 11;
                    break;
                case 4:
                    storyLabel.Text = "You sleep in. You feel a little more rested than before.";
                    questionLabel.Text = "Get up?";
                    firstOptionButton.Text = "Yes";
                    secondOptionButton.Text = "No";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    break;
                case 5:
                    storyLabel.Text = "Wow! You slept for the entire day.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    page = 99;
                    break;
                case 6:
                    storyLabel.Text = "You look for cereal, but the only cereal you find is half a box of Rice Krispies that expired five years ago. Also, there's no milk.";
                    questionLabel.Text = "What do you do?";
                    firstOptionButton.Text = "Eat it anyway";
                    secondOptionButton.Text = "Look for something else";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    pictureBox.Image = Properties.Resources.cereal;
                    break;
                case 7:
                    storyLabel.Text = "You eat that dry, ancient cereal, it was not a good experience.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    page = 11;
                    break;
                case 8:
                    storyLabel.Text = "You find the bacon and eggs, but before you are able to cook them, the power goes out";
                    questionLabel.Text = "What do you do?";
                    firstOptionButton.Text = "Look for cereal in the basement";
                    secondOptionButton.Text = "Just skip breakfast";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    break;
                case 9:
                    storyLabel.Text = "Breakfast is a very important meal. Because of being too hungry, you fall unconscious for the rest of the day.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    page = 99;
                    break;
                case 10:
                    storyLabel.Text = "The basement is very dark, so you fall down the stairs and become unconscious for the rest of the day";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    pictureBox.Image = Properties.Resources.stairs;
                    Refresh();
                    Thread.Sleep(2000);
                    page = 99;
                    break;
                case 12:
                    storyLabel.Text = "You go to see who it is and it's Steve Harvey!! You invite him in. He says he has chosen a random person to spend the rest of the day with and you're the lucky one he chose!";
                    questionLabel.Text = "What activity do you want to do with him?";
                    firstOptionButton.Text = "Baseball";
                    secondOptionButton.Text = "The Family Feud board game";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    pictureBox.Image = Properties.Resources.steve;
                    break;
                case 13:
                    storyLabel.Text = "The person who knocked on your door walks away. You check to see who it was, But it's no ordinary person. They seem mysterious.";
                    questionLabel.Text = "Run outside to meet them or not risk it?";
                    firstOptionButton.Text = "Run outside";
                    secondOptionButton.Text = "Don't risk it";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    break;
                case 14:
                    storyLabel.Text = "The man turns out to be Steve Harvey!! You are extremely disappointed in yourself for not answering the door and you're depressed for the rest of the day.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    page = 99;
                    break;
                case 15:
                    storyLabel.Text = "Steve likes the idea of playing baseball. He lets you choose whether you be the pitcher or batter first.";
                    questionLabel.Text = "Which position do you choose?";
                    firstOptionButton.Text = "Pitcher";
                    secondOptionButton.Text = "Batter";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "1\n2";
                    break;
                case 16:
                    storyLabel.Text = "You throw Steve the ball. He hits it!";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    number = random.Next(1, 101);
                    if (number < 51)
                    {
                        page = 20;
                        storyLabel.Text = "The ball goes far, but you are able to catch it!";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        Refresh();
                        Thread.Sleep(2000);
                        page = 22;
                    }
                    else
                    {
                        page = 18;
                        storyLabel.Text = "Oh no! The ball comes flying toward you, hits you in the face, and knocks you out for the rest of the day.";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        pictureBox.Image = Properties.Resources.knockedoutbaseball;
                        Refresh();
                        Thread.Sleep(2000);
                        page = 99;
                    }
                    break;
                case 17:
                    storyLabel.Text = "Steve throws you the ball. You hit it!";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    number = random.Next(1, 101);
                    if (number < 61)
                    {
                        page = 21;
                        storyLabel.Text = "The ball goes flying... You got a home run!";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        Refresh();
                        Thread.Sleep(2000);
                        page = 22;
                    }
                    else
                    {
                        page = 19;
                        storyLabel.Text = "The ball goes flying but... Oh no! The ball smashes into the window of Steve's $1 million Bugatti! He is extremely upset and drives away. You are depressed for the rest of the day.";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        pictureBox.Image = Properties.Resources.bugatti;
                        Refresh();
                        Thread.Sleep(2000);
                        page = 99;
                    }
                    break;
                case 23:
                    storyLabel.Text = "Steve is impressed by the fact that you have his favourite board game.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    pictureBox.Image = Properties.Resources.boardgame;
                    Refresh();
                    Thread.Sleep(3000);
                    page = 24;
                    storyLabel.Text = "He asks the first question... 'Name something you find in your kitchen.'";
                    questionLabel.Text = "What do you answer?";
                    firstOptionButton.Text = "Fridge";
                    secondOptionButton.Text = "Microwave";
                    thirdOptionButton.Text = "Couch";
                    firstOptionButton.Visible = true;
                    secondOptionButton.Visible = true;
                    thirdOptionButton.Visible = true;
                    optionLabel.Text = "1\n2\n3";
                    break;
                case 26:
                    storyLabel.Text = "He says, 'Good answer.' You proceed to play the rest of the game with Steve.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    number = random.Next(1, 101);
                    if (number < 31)
                    {
                        page = 28;
                        storyLabel.Text = "You finish the game and win. Steve congratulates you and says you should be on Family Feud sometime.";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        Refresh();
                        Thread.Sleep(4000);
                        page = 29;
                        storyLabel.Text = "Steve takes you out to a restaurant to get fish and chips. It was delicious. Later, Steve says goodbye and you go to bed feeling happy.";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        Refresh();
                        Thread.Sleep(2000);
                        page = 99;
                    }
                    else
                    {
                        page = 27;
                        storyLabel.Text = "Later on in the game, he asks you, 'Name something you can keep as a pet.' For some strange reason, you just yell out 'cheeseburger!'";
                        questionLabel.Text = "";
                        firstOptionButton.Text = "";
                        secondOptionButton.Text = "";
                        thirdOptionButton.Text = "";
                        firstOptionButton.Visible = false;
                        secondOptionButton.Visible = false;
                        thirdOptionButton.Visible = false;
                        optionLabel.Text = "";
                        Refresh();
                        Thread.Sleep(4000);
                        page = 25;
                    }
                    break;
                case 100:
                    storyLabel.Text = "Thanks For playing.";
                    questionLabel.Text = "";
                    firstOptionButton.Text = "";
                    secondOptionButton.Text = "";
                    thirdOptionButton.Text = "";
                    firstOptionButton.Visible = false;
                    secondOptionButton.Visible = false;
                    thirdOptionButton.Visible = false;
                    optionLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
            }

            if (page == 11)
            {
                storyLabel.Text = "Soon after you finish breakfast, You hear someone knocking on your door.";
                questionLabel.Text = "What do you do?";
                firstOptionButton.Text = "Answer it";
                secondOptionButton.Text = "Ignore it and pretend you're not home";
                thirdOptionButton.Text = "";
                firstOptionButton.Visible = true;
                secondOptionButton.Visible = true;
                thirdOptionButton.Visible = false;
                optionLabel.Text = "1\n2";
            }
            if (page == 22)
            {
                storyLabel.Text = "You have a fun time playing baseball with Steve Harvey. You go home with him and eat BLT sandwiches for supper. When he leaves, you say goodbye and go to bed feeling happy.";
                questionLabel.Text = "";
                firstOptionButton.Text = "";
                secondOptionButton.Text = "";
                thirdOptionButton.Text = "";
                firstOptionButton.Visible = false;
                secondOptionButton.Visible = false;
                thirdOptionButton.Visible = false;
                optionLabel.Text = "";
                Refresh();
                Thread.Sleep(2000);
                page = 99;
            }
            if (page == 25)
            {
                storyLabel.Text = "Steve is speechless because you gave such a bad answer. He just leaves without saying anything. You go to bed feeling angry with yourself.";
                questionLabel.Text = "";
                firstOptionButton.Text = "";
                secondOptionButton.Text = "";
                thirdOptionButton.Text = "";
                firstOptionButton.Visible = false;
                secondOptionButton.Visible = false;
                thirdOptionButton.Visible = false;
                optionLabel.Text = "";
                pictureBox.Image = Properties.Resources.surprisedsteve;
                Refresh();
                Thread.Sleep(2000);
                page = 99;
            }
            if (page == 99)
            {
                questionLabel.Text = "Start again?";
                firstOptionButton.Text = "Yes";
                secondOptionButton.Text = "No";
                thirdOptionButton.Text = "";
                firstOptionButton.Visible = true;
                secondOptionButton.Visible = true;
                thirdOptionButton.Visible = false;
                optionLabel.Text = "1\n2";
            }
        }

        private void firstOptionButton_Click(object sender, EventArgs e)
        {
            if(page == 1)
            {
                page = 2;
            }
            else if(page == 2)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 4)
            {
                page = 2;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 12;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 99)
            {
                page = 1;
            }

            StoryOutput();
        }

        private void secondOptionButton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 2;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 23;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 99)
            {
                page = 100;
            }

            StoryOutput();
        }

        private void thirdOptionButton_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 6;
            }
            else if (page == 24)
            {
                page = 25;
            }

            StoryOutput();
        }
    }
}
