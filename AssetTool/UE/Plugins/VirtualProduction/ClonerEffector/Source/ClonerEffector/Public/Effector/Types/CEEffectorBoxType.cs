namespace AssetTool
{
    [JsonAsset("CEEffectorBoxType")]
    public class UCEEffectorBoxType : UCEEffectorBoundType
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}