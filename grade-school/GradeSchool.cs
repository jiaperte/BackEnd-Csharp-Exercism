using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
    private IDictionary<string, int> studentList = new Dictionary<string, int>();

    public void Add(string student, int grade)
    {
        studentList.Add(student, grade);
        //throw new NotImplementedException("You need to implement this function.");
    }

    public IEnumerable<string> Roster()
    {
        //Fist order by grade and then order by alphabet use Thenby
        return studentList.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToArray();
        throw new NotImplementedException("You need to implement this function.");
    }

    public IEnumerable<string> Grade(int grade)
    {
        return studentList.Where(x => x.Value == grade)
                            .Select(x => x.Key).OrderBy(x => x).ToArray();
        throw new NotImplementedException("You need to implement this function.");
    }
}