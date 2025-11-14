namespace AssetTool
{
    [JsonAsset("CineAssemblyTakeRecorderSettings")]
    public class UCineAssemblyTakeRecorderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}