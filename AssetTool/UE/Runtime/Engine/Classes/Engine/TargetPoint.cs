namespace AssetTool
{
    [JsonAsset("TargetPoint")]
    public class ATargetPoint : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}