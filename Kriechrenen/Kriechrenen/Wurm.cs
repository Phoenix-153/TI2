using System;

public class Wurm : Kriechtier
{
    public Wurm(Random random) : base(0, "~", random)
    {
    }
    public override void Kriechen()
    {

        _strecke += _random.Next(0, 7);

    }
}
