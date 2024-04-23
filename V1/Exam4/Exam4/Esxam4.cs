using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

class Exam4
{
    //public string Name { get; set; }
    private string id;
    private int score1;
    private int score2;
    private string name;
    public Exam4(string id, string name, int score1, int score2)
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
        set
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
        set
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
        set 
        { 
            if(value >= 0)
            {
                score1 = value;
            }
        }
    }

    public int Score2
    {
        get
        {
            return score2;
        }
        set
        {
            if (value >= 0)
            {
                score2 = value;
            }
        }
    }

    public decimal GetAggregate()
    {
        return score1 + score2;
    }

    public decimal GetPercentage()
    {
        return (decimal)(score1 + score2) / 240 * 100;
    }
}
