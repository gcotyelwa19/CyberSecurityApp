using System;
using System.Collections.Generic;

class Quiz
{
    private int score = 0;
    private List<string> incorrectAnswers = new List<string>();

    public void Start()
    {
        // Quiz colour change!! so it stands out more
        Console.ForegroundColor = ConsoleColor.Cyan;    
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
            }, 1),

            // New questions
            ("What is malware?", new string[] {
                "1. Harmful software designed to damage or steal data",
                "2. A secure password manager",
                "3. A type of encryption",
                "4. A safe website"
            }, 1),

            ("What is social engineering?", new string[] {
                "1. Manipulating people to reveal confidential info",
                "2. Designing secure networks",
                "3. Writing strong code",
                "4. Encrypting files"
            }, 1),

            ("Why are software updates important?", new string[] {
                "1. They patch security holes",
                "2. They make your computer slower",
                "3. They delete old files",
                "4. They are optional"
            }, 1),

            ("What does VPN stand for?", new string[] {
                "1. Virtual Private Network",
                "2. Very Personal Notebook",
                "3. Verified Password Node",
                "4. Virtual Protection Number"
            }, 1),

            ("What is a data breach?", new string[] {
                "1. Unauthorized access to sensitive information",
                "2. A type of firewall",
                "3. A secure login process",
                "4. An antivirus update"
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Correct!\n");
                Console.ForegroundColor = ConsoleColor.Cyan; // Reset to quiz colour
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Incorrect.\n");
                Console.ForegroundColor = ConsoleColor.Cyan; // Reset to quiz colour
                incorrectAnswers.Add($"{q.Question} - Correct answer: {q.Options[q.Correct - 1]}");
            }
        }

        Console.WriteLine($"Quiz finished! Your score: {score}/{questions.Count}");

        if (incorrectAnswers.Count > 0)
        {
            Console.WriteLine("\nReview of incorrect answers:");
            foreach (var item in incorrectAnswers)
            {
                Console.WriteLine(item);
            }
        }

        // Reset console colour after quiz
        Console.ResetColor();
    }
}