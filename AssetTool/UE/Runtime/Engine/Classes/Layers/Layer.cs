namespace AssetTool
{
    [JsonAsset("Layer")]
    public class ULayer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}