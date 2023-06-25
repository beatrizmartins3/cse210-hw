public class Goal
{
    
    protected string _name;
    protected string  _description;
    protected string _points;

    //protected int _bonus;
    //protected int _manyBonus;
    public Goal( string name, string descrip, string p)//, int bonus, int many)
    {
       
        _name=name;
        _description=descrip;
        _points=p;
       // _bonus=bonus;
        //_manyBonus=many;
    }

    //public string GetG()
    //{
        //return $"{_type} ---- {_name} ---- {_description} ---- {_points } ---- {_bonus} ---- {_manyBonus}";
    //}

    public virtual void GetGoal()
    {


        Console.Write(_name);
        Console.ReadLine();
        Console.Write( _description);
        Console.ReadLine();
        Console.Write(_points);
        Console.ReadLine();
        
        //Console.WriteLine("The types of Goals are:");
        //Console.WriteLine("1. Simple Goal");
        //Console.WriteLine("2. Eternal Goal");
        //Console.WriteLine("3. Checklist Goal");


        //Console.Write("Wich type of goal would you like to create? ");
        //int _type = Convert.ToInt32(Console.ReadLine());

        //if (_type==1)
        //{
          //  Console.Write("What is the name of your goal? ");
            //_name = Console.ReadLine();

            //Console.Write("What is a short description of it? ");
            //_description = Console.ReadLine();

            //Console.Write("What is the amount of points associated with this goal? ");
            //int _points = Convert.ToInt32(Console.ReadLine());
        //}

        //if (_type==2)
        //{
            //Console.Write("What is the name of your goal? ");
            //_name = Console.ReadLine();

            //Console.Write("What is a short description of it? ");
            //_description = Console.ReadLine();

            //Console.Write("What is the amount of points associated with this goal? ");
            //int _points = Convert.ToInt32(Console.ReadLine());
        //}

        //if (_type==3)
        //{
            //Console.Write("What is the name of your goal? ");
            //_name = Console.ReadLine();

            //Console.Write("What is a short description of it? ");
            //_description = Console.ReadLine();

            //Console.Write("What is the amount of points associated with this goal? ");
            //int _points = Convert.ToInt32(Console.ReadLine());

            //Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            //int _bonus = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is the bonus for accomplishing it that many times? ");
            //int _manyBonus = Convert.ToInt32(Console.ReadLine());



        }

        //Console.Write("What is the name of your goal? ");
        //_name = Console.ReadLine();

        //Console.Write("What is a short description of it? ");
        //_description = Console.ReadLine();

        //Console.Write("What is the amount of points associated with this goal? ");
        //int _points = Convert.ToInt32(Console.ReadLine());
    
}

