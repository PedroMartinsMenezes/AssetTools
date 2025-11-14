namespace AssetTool
{
    [JsonAsset("ReplaceAssetsCommandlet")]
    public class UReplaceAssetsCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}