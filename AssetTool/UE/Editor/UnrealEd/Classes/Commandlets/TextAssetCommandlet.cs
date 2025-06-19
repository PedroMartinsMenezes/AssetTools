namespace AssetTool
{
    [JsonAsset("TextAssetCommandlet")]
    public class UTextAssetCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}