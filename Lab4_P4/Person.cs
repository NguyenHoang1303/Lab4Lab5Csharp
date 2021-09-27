namespace Lab4_P4
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Class: {this.GetType().Name} Name: {Name}, Phone: {Phone}, Email: {Email}, Address: {Address}";
        }
    }
}