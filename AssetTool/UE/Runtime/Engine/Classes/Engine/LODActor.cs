namespace AssetTool
{
    [JsonAsset("LODActor")]
    public class ALODActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}