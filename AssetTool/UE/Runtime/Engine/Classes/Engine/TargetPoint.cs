namespace AssetTool
{
    [JsonAsset("TargetPoint")]
    public class ATargetPoint : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}