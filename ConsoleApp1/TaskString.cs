namespace ConsoleApp1
{
    class TaskString : Itask
    {
        public string Run(string[] data)
            => data[0].Length.ToString();
    }
}
