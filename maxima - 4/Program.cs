namespace maxima___4
{
    internal class Program
    {
        static void Main(string[] args)
        { }
            public class School
        {
            public string name;
            public uint count;

            public School(string name, uint count)
            {
                this.name = name;
                this.count = count;
            }

            public string getName() { return name; }
            public uint getCount() { return count; }
            public removeStudent() { count--; }

        }
    }
}

