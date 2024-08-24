using RimWorld;
using Verse;

public class Hediff_MindDrive : HediffWithComps
{
    public override void PostAdd(DamageInfo? dinfo)
    {
        base.PostAdd(dinfo);
        // Custom behavior for consciousness transfer
        if (pawn.health.hediffSet.HasHediff(HediffDef.Named("ConsciousnessTransferSickness")))
        {
            pawn.skills.Learn(SkillDefOf.Shooting, -5000, true); // Reduce skill level temporarily
        }
    }
}
