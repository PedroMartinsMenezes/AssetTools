namespace AssetTool
{
    [JsonAsset("FloatingText")]
    public class AFloatingText : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}