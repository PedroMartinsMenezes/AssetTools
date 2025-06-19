namespace AssetTool
{
    [JsonAsset("InterchangeFbxSettings")]
    public class UInterchangeFbxSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}