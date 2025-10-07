using System;

public class Raupe : Kriechtier
{
    public Raupe(Random random) : base(0, "000<", random)
    {
    }
    public override void Kriechen()
    {
        int r = _random.Next(0, 2);
        if (r == 1)
        {
            _strecke += 4;
        }
    }
}
