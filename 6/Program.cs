/* Given a string s, return the longest palindromic substring in s.*/

Console.Write("Digite a string a ser analisada: ");
string s = Console.ReadLine();
string palindromicSubstring = "";


for (int i = 0; i < s.Length; i++){
    for (int j = s.Length; j > i; j--){
        string tempSubstring = s.Substring( i, j-i);
        string tempSubstringReverse = string.Join("", tempSubstring.ToCharArray().Reverse());
        if(tempSubstring == tempSubstringReverse){
            if(tempSubstring.Length > palindromicSubstring.Length){
                palindromicSubstring = tempSubstring;
            }
        }
    }
}

Console.WriteLine($"A maior substring palindrômica na string {s} é {palindromicSubstring}");