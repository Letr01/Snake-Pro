namespace Snake
{
    internal class ProgramBase
    {

        private static void ClearConsole(int screenwidth, int screenheight)
        {
            var blackLine = string.Join("", new byte[screenwidth - 2].Select(b => " ").ToArray());
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 1; i < screenheight - 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(blackLine);
            }
        }
    }
}