namespace AssetTool
{
    [JsonAsset("NiagaraBaselineController")]
    public class UNiagaraBaselineController : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraBaselineController_Basic")]
    public class UNiagaraBaselineController_Basic : UNiagaraBaselineController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraPerfBaselineActor")]
    public class ANiagaraPerfBaselineActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}