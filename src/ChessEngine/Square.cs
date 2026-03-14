// Square.cs
// Represents a single square on the chess board.
// Every square is uniquely identified by its File (column) and Rank (row).

namespace ChessEngine
{
    // The 8 columns of a chess board, labeled A through H (left to right)
    public enum File { A, B, C, D, E, F, G, H }

    // The 8 rows of a chess board, numbered 1 through 8 (bottom to top)
    // We assign explicit int values so we can convert back to numbers easily e.g. (int)Rank.Four = 4
    public enum Rank { One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8 }

    public class Square
    {
        // The column this square is on (A-H)
        // private set means only this class can change it — nobody outside can accidentally move a square
        public File File { get; private set; }

        // The row this square is on (1-8)
        public Rank Rank { get; private set; }

        // Constructor — runs when you create a new Square e.g. new Square(File.E, Rank.Four)
        // lowercase 'file' and 'rank' are the incoming parameters
        // uppercase 'File' and 'Rank' are the properties being assigned
        public Square(File file, Rank rank)
        {
            File = file;
            Rank = rank;
        }

        // Override the default ToString() so printing a Square gives "E4" instead of "ChessEngine.Square"
        // $ prefix enables string interpolation — embed values directly inside the string using {}
        // (int)Rank converts the enum e.g. Rank.Four → 4
        public override string ToString()
        {
            return $"{File}{(int)Rank}";
        }
    }
}