namespace AssetTool
{
    [JsonAsset("DMMaterialPropertyDisplacement")]
    public class UDMMaterialPropertyDisplacement : UDMMaterialProperty
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}