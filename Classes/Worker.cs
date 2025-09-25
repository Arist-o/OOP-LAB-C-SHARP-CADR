namespace Lab1_Csharp_07._09.Classes;

public class Worker
{
    public string Name { get; set; }
    public bool Gender { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }
    
    public static bool operator ==(Worker w1, Worker w2)
    {
        if (ReferenceEquals(w1, null) && ReferenceEquals(w2, null))
            return true;
        if (ReferenceEquals(w1, null) || ReferenceEquals(w2, null))
            return false;
        return w1.Name == w2.Name && w1.Position == w2.Position;
    }
    public static bool operator !=(Worker w1, Worker w2)
    {
        return !(w1 == w2);
    }
    public static Worker operator +(Worker w1, Worker w2)
    {
        if (w1 == null || w2 == null)
            throw new ArgumentNullException("Worker cannot be null");

        return new Worker
        {
            Name = w1.Name,
            Gender = w1.Gender,
            Position = w1.Position,
            Age = w1.Age,
            Experience = w1.Experience + w2.Experience
        };
    }
    public static bool operator >(Worker w1, Worker w2)
    {
        if (w1 == null || w2 == null)
            throw new ArgumentNullException("Worker cannot be null");
        return w1.Age > w2.Age;
    }
    public static bool operator <(Worker w1, Worker w2)
    {
        if (w1 == null || w2 == null)
            throw new ArgumentNullException("Worker cannot be null");
        return w1.Age < w2.Age;
    }
    public static Worker operator ++(Worker w)
    {
        if (w == null)
            throw new ArgumentNullException("Worker cannot be null");
            
        w.Experience++;
        return w;
    }
    
}