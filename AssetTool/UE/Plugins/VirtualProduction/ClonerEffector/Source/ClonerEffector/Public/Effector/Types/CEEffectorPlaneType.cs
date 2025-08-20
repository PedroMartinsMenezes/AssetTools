namespace AssetTool
{
    [JsonAsset("CEEffectorPlaneType")]
    public class UCEEffectorPlaneType : UCEEffectorBoundType
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}