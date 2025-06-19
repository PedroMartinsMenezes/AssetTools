namespace AssetTool
{
    [JsonAsset("Model")]
    public class UModel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}