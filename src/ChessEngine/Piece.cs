// Abstract class representing a chess piece
// Each specific piece (Pawn, Knight, etc.) will inherit from this class and implement its abstract methods.
// A piece has a color (White or Black) and a position (Square).
// The Piece class defines the common properties and behaviors of all chess pieces, while allowing for specific implementations in the derived classes.

namespace ChessEngine 
{
    public enum Color { White, Black } // The two colors of chess pieces
    public enum PieceType { Pawn, Knight, Bishop, Rook, Queen, King } // The different types of chess pieces
    public abstract class Piece
    {
        public Color Color { get; private set; } // The color of this piece (White or Black)
        public Square Position { get; private set; } // The current position of this piece on the board
        public PieceType Type { get; private set; } // The type of this piece (Pawn, Knight, etc.)

        // Constructor to initialize the piece's color and position
        public Piece(Color color, Square position, PieceType type)
        {
            Color = color;
            Position = position;
            Type = type;
        }

        // Abstract method to be implemented by each specific piece type
        // This method will return a list of valid moves for this piece based on the current board state
        public abstract List<Square> GetValidMoves(Board board);
    }
}