namespace AssetTool
{
    [JsonAsset("UVLayoutProperties")]
    public class UUVLayoutProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}