namespace AssetTool
{
    [JsonAsset("Layer")]
    public class ULayer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}