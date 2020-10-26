﻿//一次答辩用，战士/辅助
public class WarriorTemp : Character
{
    public WarriorTemp() : base(2500, 1750, 30)
    {
    }

    protected override int Skill()
    {
        double atk = Count_atk();
        double damage = Count_damage(2 * atk);
        Get_target().Defense(damage);
        return 1;
    }

    protected override void Die()
    {
    }
}