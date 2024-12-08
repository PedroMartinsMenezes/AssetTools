namespace AssetTool
{
    [JsonAsset("LODActor")]
    public class ALODActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}