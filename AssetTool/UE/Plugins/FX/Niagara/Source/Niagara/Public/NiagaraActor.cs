namespace AssetTool
{
    [JsonAsset("NiagaraActor")]
    public class ANiagaraActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}