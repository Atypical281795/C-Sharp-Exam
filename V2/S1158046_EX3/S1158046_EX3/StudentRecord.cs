using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentRecord
{
    private string id;
    private string name;
    private int score1;
    private int score2;
    public StudentRecord(string id, string name, int score1, int score2)
    {
        this.id = id;
        this.name = name;
        this.score1 = score1;
        this.score2 = score2;
    }

    public string Id
    {
        get
        {
            return id;
        }
        private set
        {
            id = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            name = value;
        }
    }

    public int Score1
    {
        get
        {
            return score1;
        }
        private set
        {
            score1 = value;
        }
    }

    public int Score2
    {
        get
        {
            return score2;
        }
        private set
        {
            score1 = value;
        }
    }

    public int GetAggregate()
    {
        int sum = score1 + score2;
        return sum;
    }

    public double GetPercentage()
    {
        int sum = score1 + score2;
        double average = (double)sum / 120 / 2 * 100;
        return average;
    }
}
