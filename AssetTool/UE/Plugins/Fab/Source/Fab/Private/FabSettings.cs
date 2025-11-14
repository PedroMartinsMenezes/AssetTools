namespace AssetTool
{
    [JsonAsset("FabSettings")]
    public class UFabSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}