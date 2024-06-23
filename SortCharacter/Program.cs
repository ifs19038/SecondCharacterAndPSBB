using System;
					
public class Program
{
	public string procVowel(string param){
		char[] arr = {'a','e','u','i','o'};
        string result = "";

        string container = "";

        for(int i = 0; i < param.Length; i++){
            char lower = char.ToLower(param[i]);
             for(int j = 0; j < arr.Length; j++){
                if(lower == arr[j]){
                    container += lower;
                    break;
                }
             }
        }

        char[] secondContainer = new char[container.Length];

        for(int i = 0; i < container.Length; i++){
            secondContainer[i] = container[i];
        }

        for(int i = 0; i < secondContainer.Length; i++){
            if(secondContainer[i] == '.'){
                continue;
            }else{
                result += secondContainer[i];
            }
             for(int j = i+1; j < secondContainer.Length; j++){
                if(secondContainer[i] == secondContainer[j]){
                    result += secondContainer[j];
                    secondContainer[j] = '.';
                }
             }
        }
		return result;
	}
	
	public string procConsonant(string param){
    char[] arr = {'a','e','u','i','o'};
        string result = "";

        string container = "";

        for (int i = 0; i < param.Length; i++)
        {
            char lower = char.ToLower(param[i]);
            bool flag = false;
            for (int j = 0; j < arr.Length; j++)
            {
                if (lower == arr[j])
                {
                    flag = true;
                    break;
                }
            }
            if(lower == ' '){
                continue;
            }
            else if (!flag)
            {
                container += lower;
            }
        }

        char[] secondContainer = new char[container.Length];

        for(int i = 0; i < container.Length; i++){
            secondContainer[i] = container[i];
        }

        for(int i = 0; i < secondContainer.Length; i++){
            if(secondContainer[i] == '.'){
                continue;
            }else{
                result += secondContainer[i];
            }
             for(int j = i+1; j < secondContainer.Length; j++){
                if(secondContainer[i] == secondContainer[j]){
                    result += secondContainer[j];
                    secondContainer[j] = '.';
                }
             }
        }
		return result;
	}
	
	public static void Main()
	{
		Console.Write("Input one line of words (S) : ");
		string input = Console.ReadLine();
		
		string charVowel = new Program().procVowel(input);
		string charConsonant = new Program().procConsonant(input);
			
		Console.WriteLine("Vowel Characters : ");
		Console.WriteLine(charVowel);
		Console.WriteLine("Consonant Characters : ");
		Console.WriteLine(charConsonant);
	}
}