namespace AssetTool
{
    [JsonAsset("Commandlet")]
    public class UCommandlet : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}