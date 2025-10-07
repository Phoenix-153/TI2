using System;

public abstract class Kriechtier
{
	protected int _strecke;
	protected string _symbol;
	protected Random _random;
	public Kriechtier(int stecke, string symbol, Random random)
	{
		_strecke = stecke;
		_symbol = symbol;
		_random = random;
    }
	public int Strecke
	{
		get { return _strecke; }
		set { _strecke = value; }
	}

    public void Visualisieren()
	{
		
        Console.Write(new string('_', Strecke));
		Console.WriteLine(_symbol);
    }
	public abstract void Kriechen();

}
