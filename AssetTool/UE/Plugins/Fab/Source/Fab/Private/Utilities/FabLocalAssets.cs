namespace AssetTool
{
    [JsonAsset("FabLocalAssets")]
    public class UFabLocalAssets : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}