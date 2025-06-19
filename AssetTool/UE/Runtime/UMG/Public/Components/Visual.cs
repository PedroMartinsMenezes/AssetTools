namespace AssetTool
{
    [JsonAsset("Visual")]
    public class UVisual : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}