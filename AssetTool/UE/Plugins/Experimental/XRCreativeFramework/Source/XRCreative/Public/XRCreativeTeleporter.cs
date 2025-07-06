namespace AssetTool
{
    [JsonAsset("XRCreativeTeleporter")]
    public class AXRCreativeTeleporter : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}