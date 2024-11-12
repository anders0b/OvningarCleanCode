using OvningarCleanCode.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OvningarCleanCode;

public class TestMethods
{
    public string InvertedStringMethod(string toInvert)
    {
        if(toInvert != null)
        {
            Console.WriteLine($"Original string: {toInvert}");
            var invertedString = new string(toInvert.Reverse().ToArray());
            Console.WriteLine($"Inverted string: {invertedString}");
            return new string(invertedString);

        }
        else
        {
            Console.WriteLine($"Please insert valid string");
            return string.Empty;
        }
    }
    public int Calculator()
    {
        Console.WriteLine("Please enter a number");
        var firstNumber = Console.ReadLine();
        Console.WriteLine("Please enter a number");
        var secondNumber = Console.ReadLine();
        Console.WriteLine("Please enter -, +, / or *");
        var symbol = Console.ReadLine();
        if (int.TryParse(firstNumber, out int firstResult) && int.TryParse(secondNumber, out int secondResult))
        {
            if (symbol == "*")
            {
                Console.WriteLine(firstResult * secondResult);
                return (firstResult * secondResult);
            }
            if (symbol == "/")
            {
                Console.WriteLine(firstResult / secondResult);
                return (firstResult / secondResult);
            }
            if (symbol == "-")
            {
                Console.WriteLine(firstResult - secondResult);
                return (firstResult - secondResult);
            }
            if (symbol == "+")
            {
                Console.WriteLine(firstResult + secondResult);
                return (firstResult + secondResult);

            }
            else
            {
                Console.WriteLine("Please enter valid symbol");
                return 0;
            }
        }
        else
        {
            Console.WriteLine("Please enter valid numbers");
            return 0;
        }

    }
    public List<int> SortedArray(List<int> ints)
    {
        if(ints != null)
        {
            Console.WriteLine("Unsorted array");
            foreach (var number in ints)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine("");
            var result = new List<int>(ints.OrderByDescending(x => x));
            Console.WriteLine("Sorted array (highest first)");
            foreach (var number in result)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine("");

            return result;
        }
        else
        {
            return new List<int>();
        }
    }
    public bool Palindrome(string toCheck)
    {
        if(toCheck != null)
        {
            if (toCheck.Equals(new string(toCheck.Reverse().ToArray())))
            {
                Console.WriteLine($"{toCheck} is a palindrome");
                return true;
            }
            else
            {
                Console.WriteLine($"{toCheck} is not a palindrome");
                return false;
            }
        }
        return false;
    }
    public double ConvertTemperature(string temp)
    {
        Console.WriteLine("Please select which unit to convert to");
        Console.WriteLine("1. Celsius");
        Console.WriteLine("2. Fahrenheit");
        var selection = Console.ReadLine();
        if (double.TryParse(temp, out double convertedTemp))
        {
            switch (selection)
            {
                case "1":

                      var celsiusResult = (convertedTemp - 32) * 5 / 9;
                      Console.WriteLine($"{convertedTemp} Fahrenheit is {celsiusResult} Celsius");
                      return celsiusResult;

                case "2":
                    var fResult = ((convertedTemp * 9 / 5) + 32);
                    Console.WriteLine($"{convertedTemp} Fahrenheit is {fResult} Celsius");
                    return fResult;
            }
        }
        return 0;
    }

    public string StringJoiner(List<string> strings, string separator)
    {
        if(strings != null)
        {
            return string.Join(separator, strings);
        }
        else
        {
            return string.Empty;
        }
    }
    public bool CheckPassword(string email, string password)
    {
        Dictionary<string, string> logIns = new Dictionary<string, string>();
        logIns.Add("anders@test.se", "kakapakaka");
        logIns.Add("saga@test.se", "random1");
        logIns.Add("kalle@test.se", "random2");

        if(email != null && password != null)
        {
            if (logIns.TryGetValue(email, out var checkPW))
            {
                if(checkPW == password)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Please enter valid login information");
                }
            }
            else
            {
                throw new Exception("Please enter valid login information");
            }
        }
        throw new Exception("Please enter valid login information");
    }
    public void AddToDiary(Diary diary, DiaryNotes diaryNotes)
    {
        if (diary != null && diaryNotes != null)
        {
            diary.DiaryEntries.Add(diaryNotes);
        }
    }
    public void RemoveFromDiary(Diary diary, int id)
    {
        if (diary != null)
        {
            var diaryNotes = diary.DiaryEntries.FirstOrDefault(x => x.Id == id);
            if(diaryNotes != null)
            {
                diary.DiaryEntries.Remove(diaryNotes);
            }
            else
            {
                throw new Exception("Please enter valid diarynote Id");
            }
        }
        else
        {
            throw new Exception("Please enter valid diary");
        }
    }
    public List<DiaryNotes> GetDiaryEntries(Diary diary)
    {
        if (diary != null)
        {
            return diary.DiaryEntries;
        }
        else
        {
            return new List<DiaryNotes>();
        }
    }
    public Product ConvertJsonToProduct(string json)
    {
        if(json != null)
        {
            var result = JsonSerializer.Deserialize<Product>(json);
            return result!;
        }
        else
        {
            throw new Exception("Please provide a valid json string");
        }
    }
}
