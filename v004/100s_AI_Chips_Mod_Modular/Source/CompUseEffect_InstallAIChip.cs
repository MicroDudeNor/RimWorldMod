using RimWorld;
using Verse;

public class CompUseEffect_InstallAIChip : CompUseEffect
{
    public override void DoEffect(Pawn user)
    {
        base.DoEffect(user);
        // Apply the AI Control Chip hediff
        user.health.AddHediff(HediffDef.Named("AIControlChipImplant"));
    }
}
