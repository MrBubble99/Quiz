using System;
using System.Collections.Generic;






namespace ÜbungenDieVierte
{
    class Program :User
    {
        static void Main(string[] args) 
        {


            User UserLi = new User();//inicia class User para usar metodos Logeed.NombreMethodo
            List<User> UserList = new List<User>();

            UserLi.userName = "3milio";
            UserLi.paswordWord = "123";
            UserLi.points = 8;
            UserList.Add(UserLi);

            UserLi.userName = "Valentina";
            UserLi.paswordWord = "123";
            UserLi.points = 9;
            UserList.Add(UserLi);


            List<string> UserName = new List<string>();
            List<string> UserPass = new List<string>();
            List<string> HighScoreName = new List<string>();
            List<int> HighScorePoint = new List<int>();

            HighScoreName.Add("Valentina");
            HighScorePoint.Add(9);
            HighScoreName.Add("Emilio");
            HighScorePoint.Add(8);

            UserName.Add("3milio");
            UserPass.Add("123");
            bool login = false;
            int count = 0;
            string ActualUser = "";
            for(int l = 0; l<2; l++)
            {
               

                if (login.Equals(false)) 
                {
                    Console.WriteLine("Do yo have a user? Introduce yes or no");
                    string answer = Console.ReadLine();

                    if (answer.Equals("yes"))
                    {
                        Console.WriteLine("Introduce your Username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Introduce your Passwort");
                        string passwort = Console.ReadLine();


                        for (int i = 0; i <= UserName.Count; i++)
                        {
                            if (username.Equals(UserName[i]))
                            {
                                count++;
                                ActualUser = UserName[i];

                            }
                        }
                        for (int i = 0; i <= UserPass.Count; i++)
                        {
                            if (passwort.Equals(UserPass[i]))
                            {
                                count++;

                            }
                        }

                        if (count.Equals(2))
                        {
                            Console.WriteLine("Your loged in");
                            login.Equals(true);
                        }
                        else
                        {
                            Console.WriteLine("Your Username or Passwort is wrong");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Create your User now !!!");
                        Console.WriteLine("Introduce your Username");
                        string username = Console.ReadLine();
                        UserName.Add(username);

                        Console.WriteLine("Introduce your Passwort");
                        string passwort = Console.ReadLine();
                        UserPass.Add(passwort);

                    }
                }

            }

                if (count.Equals(2))
                {
                    int quizPoints = 0;
                  


                    Console.WriteLine("You In the matrix!!! \n It's time to play\n");
                    Console.WriteLine("Select an option \n");
                    Console.WriteLine("1:Hard  2:Easy");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Your tuff. So let us play hard \n");
                            Console.Write($"Question 1 \nYour Points are: { quizPoints} \n");
                            Console.Write("Which European city hosted the 1936 Summer Olympics \n");
                            Console.Write(" 1:Berlin \n 2:Bonn \n 3:Paris \n 4:Rom");
                            int question1 = Convert.ToInt32(Console.ReadLine());
                            switch (question1)
                            {
                                case 1:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;
                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 2 \nYour Points are: { quizPoints} \n");
                            Console.Write("Name the Coffee shop in US sitcom Friends? \n");
                            Console.Write(" 1:Central Perk \n 2:Starbucks \n 3:Italien Corner \n 4:Buddys Cafe\n");
                            int question2 = Convert.ToInt32(Console.ReadLine());
                            switch (question2)
                            {
                                case 1:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                            }
                            Console.Write("Question 3 \nYour Points are: { quizPoints} \n");
                            Console.Write("How many human players are there on each side in a polo match? \n");
                            Console.Write(" 1:5 \n 2:3 \n 3:7 \n 4:4\n");
                            int question3 = Convert.ToInt32(Console.ReadLine());
                            switch (question3)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;

                            }
                            Console.Write($"Question 4 \nYour Points are: { quizPoints} \n");
                            Console.Write("In what year did Tony Blair become British Prime Minister? \n");
                            Console.Write(" 1:1995 \n 2:1997 \n 3:1992 \n 4:1987\n");
                            int question4 = Convert.ToInt32(Console.ReadLine());
                            switch (question4)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 2:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 5 \nYour Points are: { quizPoints} \n");
                            Console.Write("How many times has England won the men’s football World Cup? \n");
                            Console.Write(" 1:2 \n 2:0 \n 3:1 \n 4:3\n");
                            int question5 = Convert.ToInt32(Console.ReadLine());
                            switch (question5)
                            {
                                case 1:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 6 \nYour Points are: { quizPoints} \n");
                            Console.Write("What is the capital of New Zealand? \n");
                            Console.Write(" 1:Gisborne \n 2:Nelson \n 3:Wellington \n 4:Auckland\n");
                            int question6 = Convert.ToInt32(Console.ReadLine());
                            switch (question6)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 7 \nYour Points are: { quizPoints} \n");
                            Console.Write("From what grain is the Japanese spirit Sake made? \n");
                            Console.Write(" 1:Corn \n 2:Oats \n 3:Rice \n 4:Rye\n");
                            int question7 = Convert.ToInt32(Console.ReadLine());
                            switch (question7)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 8 \nYour Points are: { quizPoints} \n");
                            Console.Write("What was the most popular girls name in the UK in 2019? \n");
                            Console.Write(" 1:Lily \n 2:Olivia \n 3:Amelia\n 4:Sophia\n");
                            int question8 = Convert.ToInt32(Console.ReadLine());
                            switch (question8)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                                case 2:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 9 \nYour Points are: { quizPoints} \n");
                            Console.Write("In which European country would you find the Rijksmuseum? \n");
                            Console.Write(" 1:Netherlands \n 2:Sweden \n 3:Finland \n 4:Norway\n");
                            int question9 = Convert.ToInt32(Console.ReadLine());
                            switch (question9)
                            {
                                case 1:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Question 10 \nYour Points are: { quizPoints} \n");
                            Console.Write("How many permanent teeth does a dog have? \n");
                            Console.Write(" 1:42 \n 2:48 \n 3:54 \n 4:38 \n");
                            int question10 = Convert.ToInt32(Console.ReadLine());
                            switch (question10)
                            {
                                case 1:
                                    quizPoints++;
                                    Console.WriteLine("Correct answer");
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;
                                case 4:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer");
                                    break;

                            }
                            Console.Write($"Bounus Question 11 \nYour Points are: { quizPoints} \n");
                            Console.Write("On average how far away is the moon from the earth in miles? \n");
                            Console.Write(" 1:428,000 \n 2:269,000 \n 3:238,680  \n 4:238,000 \n");
                            int question11 = Convert.ToInt32(Console.ReadLine());
                            switch (question11)
                            {
                                case 1:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer \n");
                                    if (quizPoints >= HighScorePoint[0])
                                    {
                                        HighScoreName.Insert(0, ActualUser);
                                        HighScorePoint.Insert(0, quizPoints);
                                    }
                                    else
                                    {
                                        HighScoreName.Add(ActualUser);
                                        HighScorePoint.Add(quizPoints);
                                    }

                                    Console.WriteLine($"The HighScore \n");
                                    for (int s = 0; s <= HighScoreName.Count; s++)
                                    {

                                        Console.WriteLine($"{HighScoreName[s]}  {HighScorePoint[s]}");

                                    }
                                    break;

                                case 2:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer \n");
                                    if (quizPoints >= HighScorePoint[0])
                                    {
                                        HighScoreName.Insert(0, ActualUser);
                                        HighScorePoint.Insert(0, quizPoints);
                                    }
                                    else
                                    {
                                        HighScoreName.Add(ActualUser);
                                        HighScorePoint.Add(quizPoints);
                                    }

                                    Console.WriteLine($"The HighScore \n");
                                    for (int s = 0; s <= HighScoreName.Count; s++)
                                    {

                                        Console.WriteLine($"{HighScoreName[s]}  {HighScorePoint[s]}");

                                    }
                                    break;
                                case 3:
                                    quizPoints--;
                                    Console.WriteLine("Wrong answer\n");
                                    if (quizPoints >= HighScorePoint[0])
                                    {
                                        HighScoreName.Insert(0, ActualUser);
                                        HighScorePoint.Insert(0, quizPoints);
                                    }
                                    else
                                    {
                                        HighScoreName.Add(ActualUser);
                                        HighScorePoint.Add(quizPoints);
                                    }

                                    Console.WriteLine($"The HighScore \n");
                                    for (int s = 0; s <= HighScoreName.Count; s++)
                                    {

                                        Console.WriteLine($"{HighScoreName[s]}  {HighScorePoint[s]}");

                                    }
                                    break;

                                case 4:
                                    quizPoints++;
                                    Console.WriteLine("Corect answer \n");
                                    if (quizPoints >= HighScorePoint[0])
                                    {
                                        HighScoreName.Insert(0, ActualUser);
                                        HighScorePoint.Insert(0, quizPoints);
                                    }
                                    else 
                                    {
                                        HighScoreName.Add(ActualUser);
                                        HighScorePoint.Add(quizPoints);
                                    }
                                    
                                    Console.WriteLine($"The HighScore \n");
                                    for (int s = 0; s <=HighScoreName.Count; s++)
                                    {
                                        
                                        Console.WriteLine($"{HighScoreName[s]}  {HighScorePoint[s]}");
                                       
                                    }



                                    break;
                            } 

                            break;
                        case 2:
                            Console.WriteLine("So you likied easy...... it's time to grow up and hustle hard");
                            break;
                    }
                }


            }
            
            
            
        
        }

        
       
    }

   







