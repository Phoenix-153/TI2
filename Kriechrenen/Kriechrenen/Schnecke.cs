using System;

public class Schnecke : Kriechtier
{
	public Schnecke(Random random) : base(0, "@", random)
	{
	}
	public override void Kriechen()
	{

		_strecke += _random.Next(2, 5);

    }
}
