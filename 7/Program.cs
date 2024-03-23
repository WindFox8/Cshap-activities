/* The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display 
this pattern in a fixed font for better legibility) */

class Program {
    static int CountCharacters(string input) {
        return input.Length;
    }

    static string GetUserInput() {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static int GetNumberOfRows() {
        int rows;
        do {
            Console.Write("Enter the desired number of rows: ");
        } while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0);
        return rows;
    }

    static void Main(string[] args) {
        string s = GetUserInput();
        int rows = GetNumberOfRows();
        bool mode = true;
        int columns = CountCharacters(s);
        char[,] zigzag = new char[rows, columns];
        int i = 0, j = 0;

        for (i = 0; i < rows; i++) {
            for (j = 0; j < columns; j++) {
                zigzag[i, j] = ' ';
            }
        }        

        i = 0;
        j = 0;

        foreach (char c in s) {
            zigzag[i, j] = c;

            if (mode) {
                i++;
                if (i == rows) {
                    i -= 2;
                    mode = false;
                    j++;
                }
            } else {
                i--;
                j++;
                if (i == 0) {
                    mode = true;
                }
            }
        }

        for (i = 0; i < rows; i++) {
            for (j = 0; j < columns; j++) {
                Console.Write(zigzag[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
