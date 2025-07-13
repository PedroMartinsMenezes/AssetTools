namespace AssetTool
{
    [JsonAsset("DMMaterialSlot")]
    public class UDMMaterialSlot : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}