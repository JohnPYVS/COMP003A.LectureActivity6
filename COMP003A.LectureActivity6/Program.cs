namespace COMP003A.LectureActivity6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alex", 20);
            Student student2 = new Student("Jordan", 22);

            student1.Displayinfo();
            student2.Displayinfo();

            student1.Age = 21;

            student1.Displayinfo();
            student2.Displayinfo();

            /* Reflection
             * 
             * Each student object have its own data because each of the student has it's own stored fields.
             * 
             * Main does not need to know how Displayinfo works because it only needs to know that it exist, and what it does.
             * 
             * This activity demonstrate encapsulation conceptually because Main just uses the class thorugh its methods
             * and both fields and the Displayinfo just helps the class on how the line is formatted.
             */

        }
    }
}
