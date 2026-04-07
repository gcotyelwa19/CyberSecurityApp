using System;
using System.Collections.Generic;

class Quiz
{
    private int score = 0;

    public void Start()
    {
        Console.WriteLine("\n=== Cybersecurity Quiz ===");
        Console.WriteLine("Answer the following questions by typing the option number.\n");

        List<(string Question, string[] Options, int Correct)> questions = new List<(string, string[], int)>
        {
            ("What is phishing?", new string[] {
                "1. A type of firewall",
                "2. Tricking users into giving personal info",
                "3. A strong password technique",
                "4. An antivirus update"
            }, 2),

            ("Which of these is a strong password?", new string[] {
                "1. 123456",
                "2. Password",
                "3. MyName2026!",
                "4. qwerty"
            }, 3),

            ("What does a firewall do?", new string[] {
                "1. Blocks unauthorized access",
                "2. Stores passwords",
                "3. Detects malware",
                "4. Encrypts emails"
            }, 1)
        };

        foreach (var q in questions)
        {
            Console.WriteLine(q.Question);
            foreach (var opt in q.Options)
            {
                Console.WriteLine(opt);
            }

            Console.Write("Your answer: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice == q.Correct)
            {
                Console.WriteLine("✅ Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("❌ Incorrect.\n");
            }
        }

        Console.WriteLine($"Quiz finished! Your score: {score}/{questions.Count}");
    }
}