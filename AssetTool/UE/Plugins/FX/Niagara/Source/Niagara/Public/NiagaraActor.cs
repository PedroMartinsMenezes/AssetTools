namespace AssetTool
{
    [JsonAsset("NiagaraActor")]
    public class ANiagaraActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}