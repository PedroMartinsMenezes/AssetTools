namespace AssetTool
{
    [JsonAsset("SwitchboardProjectSettings")]
    public class USwitchboardProjectSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}