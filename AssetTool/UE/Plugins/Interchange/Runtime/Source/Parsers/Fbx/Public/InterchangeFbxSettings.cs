namespace AssetTool
{
    [JsonAsset("InterchangeFbxSettings")]
    public class UInterchangeFbxSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}