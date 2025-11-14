namespace AssetTool
{
    [JsonAsset("TextAssetCommandlet")]
    public class UTextAssetCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}