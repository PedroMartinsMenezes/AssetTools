namespace AssetTool
{
    [JsonAsset("RevolveProperties")]
    public class URevolveProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}