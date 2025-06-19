namespace AssetTool
{
    [JsonAsset("ReplaceAssetsCommandlet")]
    public class UReplaceAssetsCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}