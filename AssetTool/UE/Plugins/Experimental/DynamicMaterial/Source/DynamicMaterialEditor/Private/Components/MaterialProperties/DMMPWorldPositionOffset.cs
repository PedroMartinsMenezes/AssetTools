namespace AssetTool
{
    [JsonAsset("DMMaterialPropertyWorldPositionOffset")]
    public class UDMMaterialPropertyWorldPositionOffset : UDMMaterialProperty
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}