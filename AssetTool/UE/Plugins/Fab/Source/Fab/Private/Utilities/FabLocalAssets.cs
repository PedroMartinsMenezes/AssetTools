namespace AssetTool
{
    [JsonAsset("FabLocalAssets")]
    public class UFabLocalAssets : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}