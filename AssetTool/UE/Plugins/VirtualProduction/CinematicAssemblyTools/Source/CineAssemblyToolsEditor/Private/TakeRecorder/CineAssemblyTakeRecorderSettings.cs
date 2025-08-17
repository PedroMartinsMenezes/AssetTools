namespace AssetTool
{
    [JsonAsset("CineAssemblyTakeRecorderSettings")]
    public class UCineAssemblyTakeRecorderSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}