namespace AssetTool
{
    [JsonAsset("DMMaterialPropertyRoughness")]
    public class UDMMaterialPropertyRoughness : UDMMaterialProperty
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}