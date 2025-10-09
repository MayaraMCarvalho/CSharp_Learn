namespace Udemy_Session_13.Entities
{
    public class Student
    {
        public int Id { get; set; }

        override public bool Equals(object? obj)
        {
            if (obj is not Student)
                return false;

            Student other = obj as Student;
            return Id.Equals(other.Id);
        }

        override public int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
