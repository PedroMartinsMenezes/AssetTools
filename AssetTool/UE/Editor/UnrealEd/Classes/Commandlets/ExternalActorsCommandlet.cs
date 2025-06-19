namespace AssetTool
{
    [JsonAsset("ExternalActorsCommandlet")]
    public class UExternalActorsCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}