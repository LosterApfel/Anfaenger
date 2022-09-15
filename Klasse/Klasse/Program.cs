class person
{
    private string name;
    private int age;

    public person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    static void Main(string[] args)
    {
        person Frank = new person("rank", 23);
    }
}