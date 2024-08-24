using RimWorld;
using Verse;

public class Hediff_AIControlChip : HediffWithComps
{
    public override void PostAdd(DamageInfo? dinfo)
    {
        base.PostAdd(dinfo);
        // Boost skills
        pawn.skills.GetSkill(SkillDefOf.Intellectual).Level += 5;  // Increase Intellectual skill by 5
        pawn.skills.GetSkill(SkillDefOf.Shooting).Level += 5;      // Increase Shooting skill by 5
    }

    public override void Tick()
    {
        base.Tick();
        if (pawn.IsHashIntervalTick(2000)) // Check every few in-game hours
        {
            if (Rand.Chance(0.001f)) // 0.1% chance per check
            {
                pawn.mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.Berserk);
            }
        }
    }

    public override void PostRemoved()
    {
        base.PostRemoved();
        // Revert skill boosts when the AI chip is removed
        pawn.skills.GetSkill(SkillDefOf.Intellectual).Level -= 5;
        pawn.skills.GetSkill(SkillDefOf.Shooting).Level -= 5;
    }
}
