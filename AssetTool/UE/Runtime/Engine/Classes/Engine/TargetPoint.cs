namespace AssetTool
{
    [JsonAsset("TargetPoint")]
    public class ATargetPoint : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}