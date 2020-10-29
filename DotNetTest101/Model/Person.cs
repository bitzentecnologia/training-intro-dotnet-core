namespace DotNetTest101.Model
{
    public class Person
    {
        private static int BASE_ID = 1;
        private int _id;
        public int Id 
        {
            get { return _id ;}
            set 
            { 
                if (value > 0)
                    _id = value;
                else
                    _id = GenerateId();
            }
        }

        public string Name {get; set;}

        public int Age {get; set;}

        public Person(string name, int age = 0, int id = 0)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Person(){
            
        }
        private static int GenerateId()
        {
            return BASE_ID++;
        }
        
        public bool IsAdult()
        {
            return Age >= 18;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} -- {Age} yo";
        }
    }
}