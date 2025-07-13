namespace AssetTool
{
    [JsonAsset("CEEffectorBoxType")]
    public class UCEEffectorBoxType : UCEEffectorBoundType
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}