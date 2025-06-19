namespace AssetTool
{
    [JsonAsset("DiffAssetsCommandlet")]
    public class UDiffAssetsCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}