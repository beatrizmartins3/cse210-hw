public class Check: Goal
{
    protected int _bonus;
    protected int _manyBonus;
    public Check( string name, string descrip, string p, int bonus, int many) : base ( name, descrip,p)
    {
        _bonus=bonus;
        _manyBonus=many;
    }

    public override void GetGoal()
    {
        base.GetGoal();
    }
}