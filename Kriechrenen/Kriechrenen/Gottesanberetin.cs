using System;

public class Gottesanberetin : Kriechtier
{
	public Gottesanberetin(Random random) : base(0, ":-:", random)
    {
    }
    public override void Kriechen()
    {
        int r = _random.Next(0, 7);
        if (r == 1)
        {
            _strecke += 25;
        }
    }
}
