
namespace SS7Plus
{
    class Student
    {
        private string[] namelist = { "A", "B", "C", "D", "E" };

        //Indexer
        public string this[int index]
        {
            get
            {
                return namelist[index];
            }
        }

    }
}