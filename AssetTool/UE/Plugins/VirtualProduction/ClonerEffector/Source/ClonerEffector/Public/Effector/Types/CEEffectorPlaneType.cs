namespace AssetTool
{
    [JsonAsset("CEEffectorPlaneType")]
    public class UCEEffectorPlaneType : UCEEffectorBoundType
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}